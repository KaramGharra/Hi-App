using HiWPF.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for FileRow.xaml
    /// </summary>
    public partial class FileRow : UserControl
    {
        public string sender;
        public string FileName;
        public string Date;
        public byte[] FileContent;
        public string Result;
        public FileRow()
        {
            InitializeComponent();
        }

        public FileRow(string Sender,string FileName , string Date,byte[] Data)
        {
            InitializeComponent();
            this.Sender.Content = Sender;
            FN.Content = FileName;
            sender = Sender;
            this.FileName = FileName;
            this.Date = Date;
            FileContent = Data;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            Result = ws.DeleteFile(this.sender, SingletonUser.GetSingleton(null).UN, Date);
            if (Result == "File Deleted")
                MessageBox.Show("File was deleted successfully from database you can no longer download it", "Result", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            else
                MessageBox.Show("File was not deleted successfully Error:" + Result, "Result", MessageBoxButton.OK, MessageBoxImage.Error);
            ws.DeleteFileCompleted += Ws_DeleteFileCompleted;
            Ws_DeleteFileCompleted(null, null);

        }

        private void Ws_DeleteFileCompleted(object sender, WS.DeleteFileCompletedEventArgs e)
        {
            DownloadsW parentWindow = (DownloadsW)Window.GetWindow(this);
            if(Result == "File Deleted")
                parentWindow.FileRows.Children.Remove(this);
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllBytes(@"C:\Users\karam\Documents\Visual Studio 2015\Projects\HiWPF\HiWPF\bin\Debug\Downloads\" + FileName, FileContent);
            System.Diagnostics.Process.Start(@"C:\Users\karam\Documents\Visual Studio 2015\Projects\HiWPF\HiWPF\bin\Debug\Downloads\" + FileName);
        }
    }
}
