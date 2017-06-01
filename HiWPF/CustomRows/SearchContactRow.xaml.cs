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

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for SearchContactRow.xaml
    /// </summary>
    public partial class SearchContactRow : UserControl
    {
        public SearchContactRow()
        {
            InitializeComponent();
        }
        public SearchContactRow(Users Contact)
        {
            InitializeComponent();
            CN.Content = Contact.UN;
            //Add pic
        }


        private void OpenChat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SingletonChats.GetSingleton(new Chats()).OpenChatFromSearch = new Users(this.CN.Content.ToString());
            Window.GetWindow(this).Close();
        }
    }
}
