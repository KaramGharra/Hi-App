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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for FileSharing.xaml
    /// </summary>
    public partial class FileSharing : Window
    {
        public byte[] buffer;
        public string Receiver;
        public string FileType;
        public string FileName;
        public FileSharing()
        {
            InitializeComponent();
        }
        public FileSharing(string R)
        {
            InitializeComponent();
            Receiver = R;
        }
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if (RBDocument.IsChecked == true){
                dlg.Title = "Select a Document";
                dlg.Filter = "Doc Files | *.doc; *.docx; *.xls; *.ppt; *.txt, *.PDF";
                FileType = "Document";
            }
            else if (RBRar.IsChecked == true){
                dlg.Title = "Select a compressed File";
                dlg.Filter = "RAR Files | *.7z; *.rar; *.zip";
                FileType = "RAR";
            }
            else {
                dlg.Title = "Select an Image";
                dlg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
                FileType = "Image";
            }
            tbPath.Text = dlg.FileName;
            FileName = System.IO.Path.GetFileName(dlg.FileName);
            try
            {
                buffer = File.ReadAllBytes(dlg.FileName);
            }
            catch(Exception er) { System.Windows.MessageBox.Show(er.Message,"Result",MessageBoxButton.OK,MessageBoxImage.Error); }

        }

        private void RBDocument_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                RBRar.IsChecked = false;
                RBImage.IsChecked = false;
            }
            catch { }
        }

        private void RBRar_Checked(object sender, RoutedEventArgs e)
        {
            try { 
            RBDocument.IsChecked = false;
            RBImage.IsChecked = false;
            }
            catch { }
        }

        private void RBImage_Checked(object sender, RoutedEventArgs e)
        {
            try { 
            RBRar.IsChecked = false;
            RBDocument.IsChecked = false;
            }
            catch { }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            string Result = ws.Upload(SingletonUser.GetSingleton(null).UN, Receiver, FileName, FileType, buffer);
            if(Result == "Uploading Succeeded")
                System.Windows.MessageBox.Show("File was uploaded successfully","upload result",MessageBoxButton.OK,MessageBoxImage.Asterisk); 
            else
                System.Windows.MessageBox.Show("File was not uploaded successfully", "upload result", MessageBoxButton.OK, MessageBoxImage.Error);

        }
    }
}
