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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HiWPF.CustomRows
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ContactRow : UserControl
    {
        
        public ContactRow(){InitializeComponent();}
        public ContactRow(Users x) {
            InitializeComponent();
            this.CN.Content = x.UN;
        }

        private void OpenChatWindow(object sender, MouseButtonEventArgs e)
        {
            StackPanel SP = (StackPanel)this.Parent;
            ScrollViewer SV = (ScrollViewer)SP.Parent;
            Grid G = (Grid)SV.Parent;
            MainSc MS = (MainSc)G.Parent;
            TabItem newTabItem = new TabItem { Header = CN.Content };
            newTabItem.Content = new ChatWindow1(CN.Content.ToString());
            newTabItem.IsSelected = true;
            foreach (TabItem TI in MS.ChatWindows.Items)
            {
                if (TI.Header == CN.Content)
                {
                    TI.IsSelected = true;
                    return;
                }
            }
            MS.ChatWindows.Items.Add(newTabItem);
        }
    }
}
