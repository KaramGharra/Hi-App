using Conference_System;
using HiWPF.Classes;
using HiWPF.VoiceCall;
using SocketCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>

    public partial class ChatWindow1 : System.Windows.Controls.UserControl
    {
        public int Enter = 0;
        public WS.WebService1 ws = new WS.WebService1();
        List<Messages> newMSGS = new List<Messages>();
        public ChatWindow1()
        {
            InitializeComponent();
        }
        public ChatWindow1(string GN, string Creator)
        {
            InitializeComponent();
            this.Participants.Content = "";
            UNGN.Content = GN;
            this.Creator.Content = Creator;
            WS.WebService1 ws = new WS.WebService1();
            foreach (WS.Users u in ws.GetParticipantsOfGroup(GN, Creator))
            {
                this.Participants.Content += u.UN + ",";

            }
        }
        public ChatWindow1(string un)
        {
            InitializeComponent();
            UNGN.Content = un;
            Participants.Content = "";
            Thread Listen = new Thread(GetNewMesseges);
            Listen.Start();
        }

        public void GetNewMesseges()
        {
            
            while (true){
                
                
                Dispatcher.Invoke(new MethodInvoker(delegate
                {
                    try
                    {
                        System.Windows.Controls.TabControl TC = (System.Windows.Controls.TabControl)(((TabItem)Parent).Parent);
                        Grid G = (Grid)TC.Parent;
                        MainSc ms = (MainSc)G.Parent;
                        List<Messages> AllMessagesR = new List<Messages>();
                        AllMessagesR.AddRange(ms.AllMessages[UNGN.Content.ToString().ToUpper()]);
                        foreach (Messages m in AllMessagesR)
                            ms.AllMessages[UNGN.Content.ToString().ToUpper()].Remove(m);
                        AllMessagesR.Reverse();
                        newMSGS.AddRange(AllMessagesR);
                        for (int i = newMSGS.Count() - 1; i >= 0; i--)
                        {
                            MyMessages x = new MyMessages(newMSGS[i].Message);
                            x.Padding = new Thickness(10, 0, 0, 0);
                            x.Height = x.MSG.Height;
                            x.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                            x.MSG.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                            MSGS.Children.Insert(0, x);
                            newMSGS.Remove(newMSGS[i]);
                        }
                    }
                    catch (Exception) { }
                }),DispatcherPriority.Background);
            }
        }

        private void Close_MouseDown(object sender, MouseButtonEventArgs e){
            System.Windows.Controls.TabItem TI = (System.Windows.Controls.TabItem)this.Parent;
            System.Windows.Controls.TabControl TC = (System.Windows.Controls.TabControl)TI.Parent;
            System.Windows.Controls.Grid G = (Grid)TC.Parent;
            MainSc ms = (MainSc)G.Parent;
            ms.ChatWindows.Items.Remove(this.Parent);
        }

        private  void SendMessage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            string M = MSG.Text;
            M = M.Replace("\r", "");
            M = M.Replace("\n", "");
            MSG.Clear();
            MSG.Text = "";
            ws.SendMessageAsync(SingletonUser.GetSingleton(new Users()).UN.ToUpper(), UNGN.Content.ToString().ToUpper(), M);
            NewMsgs x = new NewMsgs(M);
            x.Padding = new Thickness(0, 0, 10, 0);
            x.Height = x.MSG.Height;
            x.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            x.MSG.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            MSGS.Children.Insert(0,x);
        }

        private void MSG_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string M = MSG.Text;
                if (M.Length > 0)
                {
                    //Record.Visibility = Visibility.Hidden;
                    SendMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    //Record.Visibility = Visibility.Visible;
                    SendMessage.Visibility = Visibility.Visible;
                }
            }
            catch (Exception) { }
        }

        private void MSG_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string M = MSG.Text;
            if (e.Key == Key.Enter && M.Length>0){
                    SendMessage_MouseDown(sender, null);
                    
            }
        }

        private void VoiceCall_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string ip = ws.GetIP(UNGN.Content.ToString());
            if (ip == "")
                System.Windows.MessageBox.Show(UNGN.Content + " is not online try to cantact him once he is online!", "Ops!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ws.SendInvitationAsync(SingletonUser.GetSingleton(null).UN.ToUpper(), UNGN.Content.ToString().ToUpper(), "Voice");
                System.Windows.Controls.TabItem TI = (System.Windows.Controls.TabItem)this.Parent;
                System.Windows.Controls.TabControl TC = (System.Windows.Controls.TabControl)TI.Parent;
                System.Windows.Controls.Grid G = (Grid)TC.Parent;
                MainSc ms = (MainSc)G.Parent;
                ms.Stb.Text = ms.IP.ToString();
                ms.SPtb.Text = 5000.ToString();
                ms.start.PerformClick();
                ms.Ctb.Text = ip.ToString();
                ms.CPtb.Text = 5000.ToString();
                ms.Connect.PerformClick();
                ms.window.Show();
                
            }

        }

        private void VideoCall_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string ip = ws.GetIP(UNGN.Content.ToString());
            if (ip == "")
                System.Windows.MessageBox.Show(UNGN.Content + " is not online try to cantact him once he is online!", "Ops!", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                ws.SendInvitationAsync(SingletonUser.GetSingleton(null).UN.ToUpper(), UNGN.Content.ToString().ToUpper(), "Video");
                System.Windows.Controls.TabItem TI = (System.Windows.Controls.TabItem)this.Parent;
                System.Windows.Controls.TabControl TC = (System.Windows.Controls.TabControl)TI.Parent;
                System.Windows.Controls.Grid G = (Grid)TC.Parent;
                MainSc ms = (MainSc)G.Parent;
                Form x = new Form1(ws.GetIP(UNGN.Content.ToString()));
                x.Show();
            }
        }

        private void Attachment_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window FileSharing = new FileSharing(UNGN.Content.ToString());
            FileSharing.Show();
        }
    }
}
