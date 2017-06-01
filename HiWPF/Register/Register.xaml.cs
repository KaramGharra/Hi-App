using HiWPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HiWPF.Register
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            UNstatus.Visibility = EmailStat.Visibility = FNstat.Visibility = LNstat.Visibility = Visibility.Hidden;
            pictureBox1.Visibility = pictureBox2.Visibility = pictureBox3.Visibility = pictureBox4.Visibility = Visibility.Hidden;
            button1.IsEnabled = VFC.IsEnabled = false;
        }
        private void UN_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (UN.Text.Length == 0)
                {
                    pictureBox1.Visibility = Visibility.Hidden;
                    UNstatus.Visibility = Visibility.Hidden;
                }
                else if (!Regex.IsMatch(UN.Text, @"^[a-zA-Z0-9._!*@~]+$"))
                {
                    UNstatus.Content = "Username must be at least 5 characters. No special characters allowed";
                    pictureBox1.Visibility = Visibility.Hidden;
                    UNstatus.Visibility = Visibility.Visible;
                }
                else if (Regex.IsMatch(UN.Text, @"^[a-zA-Z0-9._!*@~]+$"))
                {
                    pictureBox1.Visibility = Visibility.Hidden;
                    UNstatus.Visibility = Visibility.Hidden;
                }
            }
            catch { }
        }
        

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Email.Text.Length == 0)
                {

                    EmailStat.Visibility = Visibility.Hidden;
                    pictureBox2.Visibility = Visibility.Hidden;
                }
                else if (IsValidEmail(Email.Text) == false)
                {
                    EmailStat.Content = "Invalid Email";
                    pictureBox2.Visibility = Visibility.Hidden;
                    EmailStat.Visibility = Visibility.Visible;
                }
                else
                {
                    pictureBox2.Visibility = Visibility.Visible;
                    EmailStat.Visibility = Visibility.Hidden;
                }
                EnablebtnRig();
            }
            catch { }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
        private void FN_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (FN.Text.Length == 0)
                {
                    FNstat.Visibility = Visibility.Hidden;
                    pictureBox3.Visibility = Visibility.Hidden;
                }
                else if (Regex.IsMatch(FN.Text, @"^[a-zA-Z]+$") == false)
                {
                    FNstat.Content = "Invalid First name";
                    pictureBox3.Visibility = Visibility.Hidden;
                    FNstat.Visibility = Visibility.Visible;
                }
                else
                {
                    pictureBox3.Visibility = Visibility.Visible;
                    FNstat.Visibility = Visibility.Hidden;
                }
                EnablebtnRig();
            }
            catch { }
        }

        private void LN_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (LN.Text.Length == 0)
                {
                    LNstat.Visibility = Visibility.Hidden;
                    pictureBox4.Visibility = Visibility.Hidden;
                }
                else if (Regex.IsMatch(LN.Text, @"^[a-zA-Z]+$") == false)
                {
                    LNstat.Content = "Invalid Last name";
                    pictureBox4.Visibility = Visibility.Hidden;
                    LNstat.Visibility = Visibility.Visible;
                }
                else
                {
                    pictureBox4.Visibility = Visibility.Visible;
                    LNstat.Visibility = Visibility.Hidden;
                }
                EnablebtnRig();
            }
            catch { }
        }
        
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            VFC.IsEnabled = button1.IsEnabled = true; UN.IsEnabled = Email.IsEnabled = FN.IsEnabled = LN.IsEnabled = NN.IsEnabled = false;
            string res = ws.Register(Email.Text);
            if (res == "Code was sent")
            {
                System.Windows.Forms.MessageBox.Show("A new Verification Code was sent to your Email.", "Verification Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (res == "Email was sent before")
            {
                System.Windows.Forms.MessageBox.Show("The Email is in use.", "Verification Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void EnablebtnRig()
        {
            if (pictureBox1.Visibility == pictureBox2.Visibility &&
                pictureBox2.Visibility == pictureBox3.Visibility &&
                pictureBox3.Visibility == pictureBox4.Visibility &&
                pictureBox1.Visibility == Visibility.Visible)

                btnRegister.IsEnabled = true;
            else
                btnRegister.IsEnabled = false;

        }
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            if (Regex.IsMatch(UN.Text, @"^[a-zA-Z0-9._!*@~]+$") == true && UN.Text.Length > 4)
            {
                if (ws.UNavailable(UN.Text) == "Username is not available")
                {
                    UNstatus.Content= "Username is not available";
                    UNstatus.Visibility = Visibility.Visible;
                    pictureBox1.Visibility = Visibility.Hidden;

                }
                else if (ws.UNavailable(UN.Text) == "Available")
                {
                    pictureBox1.Visibility = Visibility.Visible;
                    UNstatus.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                UNstatus.Content = "Username must be at least 5 characters. No special characters allowed";
                pictureBox1.Visibility = Visibility.Hidden;
                UNstatus.Visibility = Visibility.Visible;
            }
            EnablebtnRig();

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            VFC.IsEnabled = false; UN.IsEnabled = Email.IsEnabled = FN.IsEnabled = LN.IsEnabled = NN.IsEnabled = true;


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            string res = ws.CheckCode(Email.Text, VFC.Text);
            if (res == "Account Verified")
            {
                System.Windows.Forms.MessageBox.Show("Your Account is Verified.", "Verification Cert.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Profile P = new Profile(UN.Text, NN.Text, FN.Text, LN.Text, "", "");
                Hide();
                Window SP = new SetPW(P);
                SP.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong Verification Code.", "Verification Cert.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
