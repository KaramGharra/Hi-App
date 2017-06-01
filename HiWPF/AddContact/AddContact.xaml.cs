using HiWPF.Classes;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for AddContact.xaml
    /// </summary>
    public partial class AddContact : System.Windows.Controls.UserControl
    {
        Users Us;
        public AddContact(){InitializeComponent();}
        public AddContact(Users U) {
            InitializeComponent();
            Us = U;
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Window PW = Window.GetWindow(this);
            PW.Close();
        }

        

            

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            string res = ws.addContact(SingletonUser.GetSingleton(new Users()).UN, UN.Text);
            if (res == "Contact Added")
            {
                System.Windows.MessageBox.Show("Contact Added", "Add Contact", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                this.Visibility = Visibility.Hidden;
                SingletonChats.GetSingleton(new Chats()).changed = 1;
                Window.GetWindow(this).Close();
                return;
            }
            else
                System.Windows.MessageBox.Show("Invalid Username", "Add Contact", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
    

}
