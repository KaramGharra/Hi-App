using HiWPF.Classes;
using HiWPF.VoiceCall;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HiWPF.ChatWindow
{
    /// <summary>
    /// Interaction logic for VoiceInvitation.xaml
    /// </summary>
    public partial class VoiceInvitation : Window
    {
        public string Contacted;
        public string Video;
        public VoiceInvitation()
        {
            InitializeComponent();
        }
        public VoiceInvitation(string con) {
            InitializeComponent();
            Contacted = con;
            Req.Content = con + " has invited you to a voice chat";
        }

        public VoiceInvitation(string con , string video)
        {
            InitializeComponent();
            Contacted = con;
            Video = video;
            Req.Content = con + " has invited you to a "+ Video +" chat";
        }

        private void btnDecline_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            ws.DeleteInvitation(Contacted, SingletonUser.GetSingleton(null).UN);
            Close();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            ws.RespondToInvitation(Contacted, "Accepted");
            this.Close();
            string ip = ws.GetIP(Contacted);
            



        }
    }
}
