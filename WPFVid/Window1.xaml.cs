using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using iConfServer.NET;
using iConfServer.NET.HelperClasses;
using iConfClient.NET;

namespace WPFDemo
{
    
    /// <summary>
    /// iConf.NET SDK WPF Demo
    /// IP 2 IP .NET framework 4.0
    /// </summary>
    public partial class Window1 : Window
    {
        private iConfServerDotNet icServer;
        private string IP;
        private iConfClient.NET.iConfClientDotNet icClient;
        public Window1()
        {
            InitializeComponent();
            icServer = new iConfServerDotNet();
            icServer.IncomingCall += new iConfServerDotNet.IncomingCallDelegate(icServer_IncomingCall);
            icServer.VideoPreviewStarted += new iConfServerDotNet.VideoPreviewStartedDelegate(icServer_VideoPreviewStarted);
            icClient = new iConfClient.NET.iConfClientDotNet();
            wfServer.Child = icServer;
            icServer.Show();
            wfClient.Child = icClient;
            icClient.Show();

        }

        public Window1(string ip)
        {
            InitializeComponent();
            icServer = new iConfServerDotNet();
            icServer.IncomingCall += new iConfServerDotNet.IncomingCallDelegate(icServer_IncomingCall);
            icServer.VideoPreviewStarted += new iConfServerDotNet.VideoPreviewStartedDelegate(icServer_VideoPreviewStarted);
            IP = ip;
            try
            {
                icClient = new iConfClientDotNet();
            }
            catch { }
            wfServer.Child = icServer;
            icServer.Show();
            wfClient.Child = icClient;
            icClient.Show();

        }

        void icServer_VideoPreviewStarted(int videoWidth, int videoHeight, string deviceName)
        {
            this.Dispatcher.Invoke(new MethodInvoker(delegate
            {
                //Initialize Codec -- MPEG 4, iframe frequency 20, bitrate 8000 bps

                icServer.SetEncoderProperties(VideoCodecs.MPEG4, 20, 8000, 0, 0, 0);

                if (!icServer.IsListening)
                {
                    //listen for incoming connections
                    try
                    {
                        icServer.Listen(true, icServer.GetLocalIp()[0].ToString(), 9990, 17860, 17861);
                    }
                    catch { }
                }
            }));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            txtIP.Text = icServer.GetLocalIp()[0].ToString();

            LoadVideoDevices();

            icServer.InitializeAudioSystem(iConfServer.NET.iConfServerDotNet.audioType.DirectSound, -1, -1, 16000, 10);
            //select the first available video device

            cbDevices.SelectedIndex = 0;

            icServer.StartPreview(0);

           
        }

        private void LoadVideoDevices()
        {
            ArrayList devs = icServer.GetVideoDevices();

            for (int i = 0; i < devs.Count; i++)
            {
                cbDevices.Items.Add(devs[i].ToString());   
            }
        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
            string myIp = icServer.GetLocalIp()[0].ToString();
            string ipToCall = txtIP.Text;
            int videoPort = 9990;
            int audioTcpPort = 17860;
            int audioUdpPort = 17861;

            if (btnCall.Content.ToString() == "Hang up")
            {
                icClient.Disconnect();
                icClient.ClearImage();
                btnCall.Content = "Call";
                return;
            }
            //place a call to an iConf Server
            //note when using the Call function we have the ability to supply callback parameters 
            //which will help the peer connection call us back

            btnCall.Content = "Hang up";
            icClient.Call(ipToCall, videoPort, 0, 0, "test", icServer.CallBackId, myIp, videoPort, audioTcpPort, audioUdpPort, "");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //stop listening
            icServer.Listen(false, icServer.GetLocalIp()[0].ToString(), 9990, 17860, 17861);

            //stop the video preview
            icServer.StopPreview();
        }

        private void cbDevices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            icServer.SelectVideoDevice(cbDevices.SelectedIndex);
            icServer.StartPreview(0);    
        }

        public delegate void ProcessIncomingCallDelegate(string authenticationData, int socketHandle, string callbackid, string callbackipaddress, int callbackvideoport, int callbackaudiotcpport, int callbackaudiudpport);

        private void ProcessIncomingCall(string authenticationData, int socketHandle, string callbackid, string callbackipaddress, int callbackvideoport, int callbackaudiotcpport, int callbackaudiudpport)
        {
            //accept the incoming call
            icServer.AcceptCall("n/a", socketHandle);

            //call back to have a 1 on one video conference
            icClient.Call(callbackipaddress, callbackvideoport, 0, 0, "n/a", callbackid, icServer.GetLocalIp()[0].ToString(), 0, 0, 0, "");
        }



        private void icServer_IncomingCall(object sender, string authenticationData, int socketHandle, string callbackid, string callbackipaddress, int callbackvideoport, int callbackaudiotcpport, int callbackaudiudpport)
        {
            //always use delegates in the event handler to go back and use 
            //your main UI thread or you will get Illegal Cross Thread Errors
            this.Dispatcher.Invoke(new ProcessIncomingCallDelegate(ProcessIncomingCall), new object[] { authenticationData, socketHandle, callbackid, callbackipaddress, callbackvideoport, callbackaudiotcpport, callbackaudiudpport });

        }
    }
}
