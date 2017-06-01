using HiWPF.Classes;
using HiWPF.CustomRows;
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

namespace HiWPF.AddGroup
{
    /// <summary>
    /// Interaction logic for CreateGroup.xaml
    /// </summary>
    public partial class CreateGroup : UserControl
    {
        public CreateGroup()
        {
            InitializeComponent();
            foreach (Users contact in SingletonChats.GetSingleton(new Chats()).Cchats)
                Contacts.Children.Add(new ContactRowForAddGroup(contact));
        }

        private void btnAddGroup_Click(object sender, RoutedEventArgs e)
        {
            if (GN.Text != "" && !string.IsNullOrEmpty(GN.Text.ToString()))
            {
                string G_Name = this.GN.Text;
                string Creator = SingletonUser.GetSingleton(new Users()).UN;
                WS.WebService1 ws = new WS.WebService1();
                List<Users> u = new List<Users>();
                foreach (ContactRowForAddGroup c in this.Contacts.Children)
                    if (c.Chosen.IsChecked == true)
                        u.Add(new Users(c.CN.Content.ToString()));
                //Create group with name G_Name & Creator AddParticipants
                ws.createGroup(Creator, G_Name);
                foreach (Users contact in u)
                    ws.AddToGroupAsync(Creator, G_Name, contact.UN);
                SingletonChats.GetSingleton(new Chats()).changed = 1;
                MessageBox.Show("Group was created.", "Creating Group Result", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                Window.GetWindow(this).Close();
                return;
            }
            MessageBox.Show("Group was not created.", "Creating Group Result", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
