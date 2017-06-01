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
using System.Windows.Forms;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for MainScW.xaml
    /// </summary>
    public partial class MainScW : Window
    {
        public MainScW()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.WindowStyle = WindowStyle.None;
            this.ShowInTaskbar = true;
            
        }

        private void DeleteIP(object sender, EventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            ws.DeleteIPAddressAsync(SingletonUser.GetSingleton(null).UN);
        }

         private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            // Create the interop host control.
            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            // Create the MaskedTextBox control.
            TCPStreamer.TCPSControl tc = new TCPStreamer.TCPSControl();

            // Assign the MaskedTextBox control as the host control's child.
            host.Child = tc;

            // Add the interop host control to the Grid
            // control's collection of child controls.
            this.grid1.Children.Add(host);*/
        }
    }
}
