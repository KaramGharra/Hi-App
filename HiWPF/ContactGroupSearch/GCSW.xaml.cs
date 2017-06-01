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

namespace HiWPF.ContactGroupSearch
{
    /// <summary>
    /// Interaction logic for GCSW.xaml
    /// </summary>
    public partial class GCSW : Window
    {
        public GCSW()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            this.ShowInTaskbar = true;
        }
    }
}
