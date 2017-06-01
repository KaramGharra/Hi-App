using HiWPF.Classes;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for DownloadsW.xaml
    /// </summary>
    public partial class DownloadsW : Window
    {
        public DownloadsW()
        {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            WS.Files[] Files =  ws.GetFiles(SingletonUser.GetSingleton(null).UN);
            foreach (WS.Files f in Files)
                FileRows.Children.Add(new FileRow(f.Sender, f.FileName,f.Date,f.FileContent));
        }
    }
}
