using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.IO;
using System.Net;
using System.Net.Sockets;
using HiWPF.Classes;
using System.Threading;
using System.Media;

namespace HiWPF
{
    class AudioStreamer
    {
        public IPAddress Sip;
        public WaveIn In;
        public WaveOut Out;
        public Byte[] Data_ary;
        public WaveFileWriter WFW = null;
        public Socket AudioServer = null , RecSocket = null , sock = null;
        public NetworkStream ns;
        private System.Windows.Forms.Timer c_v = null;
        public AudioStreamer(string ServerIP) {
            In = new WaveIn();
            Out = new WaveOut();
            Sip = IPAddress.Parse(ServerIP);
            c_v = new System.Windows.Forms.Timer();
            c_v.Tick += C_v_Tick; ;
        }

        private void C_v_Tick(object sender, EventArgs e)
        {
            this.Clean();
            Send_Bytes();
        }

        //Bind to A button untill 
        public void Record() {
            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                if (NAudio.Wave.WaveIn.GetCapabilities(i).ProductName.Contains("icrophone"))
                    In.DeviceNumber = i;
            In.WaveFormat = new WaveFormat(22000, WaveIn.GetCapabilities(In.DeviceNumber).Channels);

            In.StartRecording();
            
            In.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
            WFW= new WaveFileWriter(AppDomain.CurrentDomain.BaseDirectory + "\\buffer", In.WaveFormat);
            c_v.Start();
        }

        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (WFW == null) return;
            WFW.Write(e.Buffer, 0, e.BytesRecorded);
            WFW.Flush();

        }

        private void Send_Bytes()
        {
            Data_ary = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\buffer");
            AudioServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(Sip, int.Parse(Getters.offsetPort.ToString()));
            ie.Address = IPAddress.Loopback;
            AudioServer.Connect(ie);
            AudioServer.Send(Data_ary, 0, Data_ary.Length, 0);
            AudioServer.Close();
            Record();
        }

        public void Receive()
        {
            
            Thread rec_thread = new Thread(new ThreadStart(VoiceReceive));
            rec_thread.Start();

        }
        private void WriteBytes()
        {
            if (ns != null)
            {
                SoundPlayer sp = new SoundPlayer(ns);
                sp.Play();
            }
        }
        private void VoiceReceive()
        {
            long p = Getters.offsetPort;
            long max = Getters.offsetPort+500;
            while (p != max)
            {
                try
                {
                    RecSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ie = new IPEndPoint(0, int.Parse((p++).ToString()));

                    RecSocket.Bind(ie);

                    RecSocket.Listen(0);
                    sock = RecSocket.Accept();
                    ns = new NetworkStream(sock);


                    WriteBytes();
                    RecSocket.Close();

                    while (true)
                    {
                        VoiceReceive();
                    }
                }
                catch { }
            }


        }

        private void Clean()
        {
            c_v.Stop();
            if (In != null){
                In.StopRecording();
                In.Dispose();
            }
            if (WFW != null)
                WFW.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
