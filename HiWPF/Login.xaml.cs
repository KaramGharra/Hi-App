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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        WS.WebService1 ws = new WS.WebService1();
        public Login()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ws.VerifyUsers(UN.Text.ToUpper(), PW.Password) == "Verified")
            {
                this.Hide();
                SingletonUser.GetSingleton(new Users(UN.Text.ToUpper(), PW.Password));
                MainScW MS = new MainScW();
                MS.Show();
                Close();
                //Form MS = new MainScF();
                //MS.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or password");
            }

        }

        

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }

        private void Register_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window RegisterW = new Register.Register();
            RegisterW.Show();
        }
    }
}
