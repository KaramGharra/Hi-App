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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for MyMessages.xaml
    /// </summary>
    public partial class MyMessages : UserControl
    {
        public MyMessages()
        {
            InitializeComponent();
            this.Height = double.NaN;
            this.Width = double.NaN;
        }
        public MyMessages(string MSG)
        {
            InitializeComponent();
            this.MSG.Text = MSG;
        }
    }
}
