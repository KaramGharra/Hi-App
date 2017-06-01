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
    /// Interaction logic for SearchGroupRow.xaml
    /// </summary>
    public partial class SearchGroupRow : UserControl
    {
        public SearchGroupRow()
        {
            InitializeComponent();
        }
        public SearchGroupRow(GroupInfo g) {
            InitializeComponent();
            GN.Content = g.G_Name;
            Creator.Content = g.Creator;
            //Add group picture
        }

        private void OpenChat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SingletonChats.GetSingleton(new Chats()).OpenGroupFromSearch = new GroupInfo(GN.Content.ToString(), Creator.Content.ToString());
            Window.GetWindow(this).Close();
        }
    }
}
