using Conference_System;
using HiWPF.AddGroup;
using HiWPF.ChatWindow;
using HiWPF.Classes;
using HiWPF.ContactGroupSearch;
using HiWPF.CustomRows;
using HiWPF.UpdateProfile;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using TCPStreamer;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for MainSc.xaml
    /// </summary>
    public partial class MainSc : System.Windows.Controls.UserControl
    {
        public WS.WebService1 ws = new WS.WebService1();
        SingletonChats ChatsR = SingletonChats.GetSingleton(new Chats());
        public int ShowHide = 0 ;
        public int Show = 0;
        public IPAddress IP;
        private readonly object _lock = new object();
        private static Mutex mut = new Mutex();
        public List<Messages> newMsgs = new List<Messages>();
        public WS.Messages[] _SSMSG;
        public List<WS.Messages> SSMSG = new List<WS.Messages>();
        public volatile bool NewMSG , run;
        public Dictionary<string, List<Messages>> AllMessages = new Dictionary<string, List<Messages>>();
        public System.Windows.Forms.TabControl tc;
        public Form window;
        //Server side - voice
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.TextBox Stb;
        public System.Windows.Forms.TextBox SPtb;
        public System.Windows.Forms.GroupBox gb;
        //Client side - voice
        public System.Windows.Forms.Button Connect;
        public System.Windows.Forms.TextBox Ctb;
        public System.Windows.Forms.TextBox CPtb;
        public System.Windows.Forms.GroupBox Cgb;
        public System.Windows.Forms.GroupBox Sgb;
        public System.Windows.Forms.Button muteMic;
        public System.Windows.Forms.Button muteSound;
        // For Opening Port
        SerialPort serialPort; // doesnt work
        //initializing HomePage
        public MainSc()
        {

            InitializeComponent();
            window = new FormMain();
            window.Hide();
            foreach (System.Windows.Forms.Control c in window.Controls)
            {
                try
                {
                    System.Windows.Forms.TabControl t = (System.Windows.Forms.TabControl)c;
                    tc = t;
                }
                catch { }
            }
            // Server
            System.Windows.Forms.TabPage tp = tc.TabPages[0];
            foreach (System.Windows.Forms.Control c in tp.Controls) {
                try{
                    System.Windows.Forms.GroupBox x = (System.Windows.Forms.GroupBox)c;
                    if(x.Name == "GroupBoxServer")
                        gb = x;
                }catch { }
            }
            foreach (System.Windows.Forms.Control c in gb.Controls)
            {
                try {
                    System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)c;
                    if (tb.Name == "TextBoxServerAddress")
                        Stb = tb;
                    else if (tb.Name == "TextBoxServerPort")
                        SPtb = tb;
                }
                catch { }
            }
            foreach (System.Windows.Forms.Control c in gb.Controls)
            {
                try
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)c;
                    if (btn.Name == "ButtonServer")
                        start = btn;
                }
                catch { }
            }
            //Client
            tp = tc.TabPages[1];
            foreach (System.Windows.Forms.Control c in tp.Controls)
            {
                try
                {
                    System.Windows.Forms.GroupBox gbt = (System.Windows.Forms.GroupBox)c;
                    if (gbt.Name == "GroupBoxClient")
                        Cgb = gbt;
                    else if (gbt.Name == "GroupBoxSound")
                        Sgb = gbt;
                }
                catch { }
            }
            foreach (System.Windows.Forms.Control c in Cgb.Controls)
            {
                try
                {
                    System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)c;
                    if (tb.Name == "TextBoxClientAddress")
                        Ctb = tb;
                    else if (tb.Name == "TextBoxClientPort")
                        CPtb = tb;
                }
                catch { }
            }
            foreach (System.Windows.Forms.Control c in Cgb.Controls)
            {
                try
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)c;
                    if (btn.Name == "ButtonClient")
                        Connect = btn;
                }
                catch { }
            }
            foreach (System.Windows.Forms.Control c in Sgb.Controls)
            {
                try
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)c;
                    if (btn.Name == "ButtonClientSpeak")
                        muteMic = btn;
                    else if (btn.Name == "ButtonClientListen")
                        muteSound = btn;
                }
                catch { }
            }

            tc.TabPages[0].Enabled = true;
            ChatsR.Cchats = Getters.GetContacts();
            ChatsR.Gchats = Getters.GetGroups();
            foreach (Users contact in ChatsR.Cchats)
                Chats.Children.Add(new ContactRow(contact));
            //foreach (GroupInfo G in ChatsR.Gchats)
              //  Chats.Children.Add(new GroupRow(G));
            UN.Content = SingletonUser.GetSingleton(new Users()).UN;
            Profile UNP = Getters.GetUserProfile(SingletonUser.GetSingleton(new Users()).UN);
            SingletonChats.GetSingleton(new Chats()).Prof = UNP;
            NN.Content = UNP.Nick_Name;
            //PP.Source = UNP.Profile_Pic; -- updating image source
            IP = Getters.GetIPAddress();
            ws.SetIPAddressAsync(SingletonUser.GetSingleton(null).UN, IP.ToString());
            Thread NewMsg = new Thread(getMsgFromDB);
            Thread Notifications = new Thread(ReadMessages);
            NewMsg.Start();
            Notifications.Start();
            Thread GetInvitations = new Thread(getInvitations);
            GetInvitations.Start();
            
        }

       // Message management for chat
        public void getMsgFromDB() {
            while (true){
                lock (_lock){
                    try{
                                                
                        _SSMSG = ws.GetAllMessages(SingletonUser.GetSingleton(new Users()).UN);
                        SSMSG.AddRange(_SSMSG.ToList());
                        if(SSMSG.Count > 0)
                            Monitor.Pulse(_lock);
                    }
                    catch (Exception){}
                }
            }
        }

        public void ReadMessages() {
            while (true){
                lock (_lock)
                {
                    try{
                        while (SSMSG == null || SSMSG.Count == 0)
                            Monitor.Wait(_lock);
                       
                        foreach (WS.Messages m in SSMSG.ToList())
                        {
                            this.Dispatcher.Invoke(new MethodInvoker(delegate
                            {
                            try
                            {
                                    if (!isOpened(new Users(m.Sender.ToUpper())))
                                    {
                                        string Day = m.Date[0].ToString() + m.Date[1].ToString();
                                        string Month = m.Date[3].ToString() + m.Date[4].ToString();
                                        string year = m.Date[6].ToString() + m.Date[7].ToString() + m.Date[8].ToString() + m.Date[9].ToString();
                                        string newD = Month + '/' + Day + '/' + year + ' ';
                                        for (int i = 10; i < m.Date.Length; i++)
                                            newD += m.Date[i].ToString();
                                        MSGNotifications.Children.Add(new NotificationMSG(new Messages(m.Sender.ToUpper(), m.Reciver.ToUpper(), m.Message, newD, m.Status)));
                                        if (!AllMessages.Keys.Contains(m.Sender.ToUpper()))
                                            AllMessages.Add(m.Sender.ToUpper(), new List<Messages>());
                                        AllMessages[m.Sender.ToUpper()].Add(new Messages(m.Sender.ToUpper(), m.Reciver.ToUpper(), m.Message, m.Date, m.Status));
                                    }
                                    else
                                    {
                                        if (!AllMessages.Keys.Contains(m.Sender.ToUpper()))
                                            AllMessages.Add(m.Sender.ToUpper(), new List<Messages>());
                                        AllMessages[m.Sender.ToUpper()].Add(new Messages(m.Sender.ToUpper(), m.Reciver.ToUpper(), m.Message, m.Date, m.Status));
                                    }
                                }
                                catch (Exception ) { }
                            }));
                            SSMSG.Remove(m);
                        }

                        
                    }
                    catch (Exception ) { }
                }
            }
        }
        /// ///////////////////////
        /// 
        private void Exit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window PW = Window.GetWindow(this);
            PW.Close();
        }

        private void ShowHideChats_MouseDown(object sender, MouseButtonEventArgs e){

            BitmapImage Hide = new BitmapImage();
            Hide.BeginInit();
            Hide.UriSource = new Uri("https://cdn3.iconfinder.com/data/icons/interface-8/128/InterfaceExpendet-02-512.png");
            Hide.EndInit();
            BitmapImage Show = new BitmapImage();
            Show.BeginInit();
            Show.UriSource = new Uri("https://cdn3.iconfinder.com/data/icons/interface-8/128/InterfaceExpendet-03-512.png");
            Show.EndInit();

            if (ShowHide%2 != 0)
            {
                Chats.Visibility = Visibility.Visible;
                ShowHideChats.Source = Hide;
                ShowHide++;
            }
            else{
                ShowHideChats.Source = Show;
                Chats.Visibility = Visibility.Hidden;
                ShowHide++;
            }
        }

        private void AddContact_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window AC = new AddContactW();
            AC.Show();
            AC.Closed += AC_Closed;
        }

        private void AC_Closed(object sender, EventArgs e)
        {
            if (SingletonChats.GetSingleton(new Chats()).changed == 1)
            {
                Chats.Children.Clear();
                List<Users> contacts = new List<Users>();
                foreach (WS.Users c in ws.getContacts(SingletonUser.GetSingleton(new Users()).UN))
                {
                    contacts.Add(new Users(c.UN));
                }
                ChatsR.Cchats = contacts;
                foreach (Users contact in contacts)
                    Chats.Children.Add(new ContactRow(contact));
                foreach (GroupInfo G in ChatsR.Gchats)
                    Chats.Children.Add(new GroupRow(G));
                SingletonChats.GetSingleton(new Chats()).changed = 0;
            }
        }

        private void AddGroup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window CG = new CreateGroupW();
            CG.Show();
            CG.Closed += CG_Closed;
        }

        private void CG_Closed(object sender, EventArgs e)
        {
            if (SingletonChats.GetSingleton(new Chats()).changed == 1)
            {
                Chats.Children.Clear();
                ChatsR.Gchats = Getters.GetGroups();
                foreach (Users contact in ChatsR.Cchats)
                    Chats.Children.Add(new ContactRow(contact));
                foreach (GroupInfo group in ChatsR.Gchats)
                    Chats.Children.Add(new GroupRow(group));
                SingletonChats.GetSingleton(new Chats()).changed = 0;
            }
        }

        private void Search_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window CGS = new GCSW();
            CGS.Show();

            CGS.Closed += CGS_Closed;
        }

        private void CGS_Closed(object sender, EventArgs e)
        {
            if (SingletonChats.GetSingleton(new Chats()).OpenChatFromSearch != null && !isOpened(SingletonChats.GetSingleton(new Chats()).OpenChatFromSearch))
            {
                TabItem newTabItem = new TabItem { Header = SingletonChats.GetSingleton(new Chats()).OpenChatFromSearch.UN };
                newTabItem.Content = new ChatWindow1(SingletonChats.GetSingleton(new Chats()).OpenChatFromSearch.UN);
                ChatWindows.Items.Add(newTabItem);
            }

            else if (SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch != null && !isOpened(SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch))
            {

                TabItem newTabItem = new TabItem { Header = SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch.G_Name};
                newTabItem.Content = new ChatWindow1(SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch.G_Name, SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch.Creator);
                ChatWindows.Items.Add(newTabItem);
                
            }

            SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch = null;
            SingletonChats.GetSingleton(new Chats()).OpenChatFromSearch = null;
        }

        public bool isOpened(Object chat)
        {
            try
            {
                ChatWindow1 CW = null;
                Users C = (Users)chat;
                foreach (TabItem c in ChatWindows.Items)
                {
                    CW = (ChatWindow1)c.Content;                    
                    if (CW.UNGN.Content.ToString().ToUpper() == C.UN.ToUpper())
                        return true;
                }
                return false;

            }
            catch (Exception)
            {
                ChatWindow1 CW = null;
                GroupInfo C = (GroupInfo)chat;
                foreach (TabItem c in ChatWindows.Items)
                {
                    CW = (ChatWindow1)c.Content;
                    if (CW.UNGN.Content.ToString() == C.G_Name && CW.Creator.Content.ToString() == C.Creator)
                        return true;
                }
                return false;
            }
        }

        private void Update_MouseDown(object sender, MouseButtonEventArgs e){
            Window UP = new UpdateProfileW();
            UP.Show();
            UP.Closed += UP_Closed;
        }

        private void NotificationMSG_Loaded(object sender, RoutedEventArgs e){}

        private void UP_Closed(object sender, EventArgs e){
            if (SingletonChats.GetSingleton(null).Pchanged)
            {
                Profile X = SingletonChats.GetSingleton(new Chats()).Prof;
                this.UN.Content = X.UN;
                this.NN.Content = X.Nick_Name;
                BitmapImage newPic = new BitmapImage();
                try
                {
                    newPic.BeginInit();
                    newPic.UriSource = new Uri(X.Profile_Pic);
                    newPic.EndInit();
                }
                catch { }
                
                this.PP.Source = newPic;
                SingletonChats.GetSingleton(null).Pchanged = false;
            }
        }

        private void Downloads_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window DownloadsW = new DownloadsW();
            DownloadsW.Show();
        }

        private void getInvitations() {
            while (true) {
                WS.Invitation I = ws.GetInvitation(SingletonUser.GetSingleton(null).UN);

                if (I != null && I.Status == "Sending")
                {
                    if (I.VidVoice == "Voice")
                    {
                        ws.ChangeInvitationStat(I.UN);
                        Dispatcher.Invoke(new MethodInvoker(delegate
                        {
                            Window VI = new VoiceInvitation(I.UN);
                            VI.Show();
                        }));

                    }
                    else if (I.VidVoice == "Video")
                    {
                        ws.ChangeInvitationStat(I.UN);
                        Dispatcher.Invoke(new MethodInvoker(delegate
                        {
                            Window VI = new VoiceInvitation(I.UN,"video");
                            VI.Show();
                        }));
                        
                    }

                }
                else if (I != null && I.Status == "Accepted") {
                    if (I.VidVoice == "Voice")
                    {
                        string cip = ws.GetIP(I.Cont.ToUpper());
                        Ctb.Text = cip;
                        CPtb.Text = 5000.ToString();
                        Dispatcher.Invoke(new MethodInvoker(delegate
                        {
                            window.Show();
                            tc.TabPages[0].Enabled = false;
                        }));
                        ws.DeleteInvitation(I.Cont, I.UN);
                    }
                    else {
                        Dispatcher.Invoke(new MethodInvoker(delegate
                        {
                            Form Video = new Form1(ws.GetIP(I.UN));
                            Video.Show();
                        }));
                        ws.DeleteInvitation(I.Cont, I.UN);

                    }
                }
            }
        }
        
    }
}
