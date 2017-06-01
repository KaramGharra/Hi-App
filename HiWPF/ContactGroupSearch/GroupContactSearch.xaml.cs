using HiWPF.Classes;
using HiWPF.CustomRows;
using System.Windows;
using System.Windows.Controls;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for GroupContactSearch.xaml
    /// </summary>
    public partial class GroupContactSearch : UserControl
    {
        public GroupContactSearch()
        {
            InitializeComponent();

            foreach (Users c in SingletonChats.GetSingleton(new Chats()).Cchats)
                Contacts.Children.Add(new SearchContactRow(c));
                
            
            foreach (GroupInfo g in SingletonChats.GetSingleton(new Chats()).Gchats)
                Groups.Children.Add(new SearchGroupRow(g));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }

        private void UGN_TextChanged(object sender, TextChangedEventArgs e)
        {
            Contacts.Children.Clear();
            foreach (Users c in SingletonChats.GetSingleton(new Chats()).Cchats)
            {
                if (c.UN.Contains(UGN.Text))
                    Contacts.Children.Add(new SearchContactRow(c));
            }
            Groups.Children.Clear();
            foreach (GroupInfo g in SingletonChats.GetSingleton(new Chats()).Gchats)
                if (g.G_Name.Contains(UGN.Text))
                    Groups.Children.Add(new SearchGroupRow(g));
        }
    }
}
