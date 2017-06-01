using Microsoft.DirectX.DirectSound;
using System;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using NAudio.Wave;
using System.Media;
using HiWPF.Classes;

namespace HiWPF.VoiceCall
{
    /// <summary>
    /// Interaction logic for VoiceRoom.xaml
    /// </summary>
    public partial class VoiceRoom : Window
    {
        private string IP;
        private int _MaxTries = 400;
        private Socket ClientSocket;
        private byte[] buffer = new byte[2205];
        private Thread th;
        AudioStreamer AS;
        public VoiceRoom() { InitializeComponent(); }
        public VoiceRoom(string ip)
        {
            InitializeComponent();
            IP = ip;
            AS = new AudioStreamer(ip);
            AS.Receive();
        }

        private void StartTalkingBTN_Click(object sender, RoutedEventArgs e)
        {
            AS.Record();
        }
    }
}