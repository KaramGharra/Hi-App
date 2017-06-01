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
    /// Interaction logic for GroupRow.xaml
    /// </summary>
    public partial class GroupRow : UserControl
    {
        public GroupRow()
        {
            InitializeComponent();
        }
        public GroupRow(GroupInfo x) {
            InitializeComponent();
            this.Creator.Content = x.Creator;
            this.GN.Content = x.G_Name;
            //this.GP.Source = new Uri(x.G_Pic); -- Updating the source of the image
        }

        private void OpenChatWindow(object sender, MouseButtonEventArgs e)
        {
            StackPanel SP = (StackPanel)this.Parent;
            ScrollViewer SV = (ScrollViewer)SP.Parent;
            Grid G = (Grid)SV.Parent;
            MainSc MS = (MainSc)G.Parent;
            TabItem newTabItem = new TabItem { Header = GN.Content };
            newTabItem.Content = new ChatWindow1(GN.Content.ToString() , Creator.Content.ToString() );
            MS.ChatWindows.Items.Add(newTabItem);
        }
    }
}
