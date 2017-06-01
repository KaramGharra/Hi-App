using HiWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace HiWPF.CustomRows
{
    /// <summary>
    /// Interaction logic for NotificationMSG.xaml
    /// </summary>
    public partial class NotificationMSG : UserControl
    {
        public NotificationMSG()
        {
            InitializeComponent();
        }
        public NotificationMSG(Messages m)
        {
            InitializeComponent();
            CN.Content = m.Sender;
            this.LM.Content = m.Message;
            this.Date.Content = (DateTime.Now - DateTime.Parse(m.Date)).ToString();
            Thread Timer = new Thread(ClosingTimer);
            Timer.Start();
        }

        void ClosingTimer() {
            Thread.Sleep(5000);
            StackPanel N = (StackPanel)Parent;
            Dispatcher.Invoke(new Action(() => { N.Children.Remove(this); }));
            

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            StackPanel N = (StackPanel)Parent;
            N.Children.Remove(this);
        }
    }
}
