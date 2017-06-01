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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HiWPF.Register
{
    /// <summary>
    /// Interaction logic for SetPW.xaml
    /// </summary>
    public partial class SetPW : Window
    {
        public Profile Pr;
        public SetPW()
        {
            InitializeComponent();
        }
        public SetPW(Profile P)
        {
            InitializeComponent();
            UN.Text = P.UN;
            Pr = P;
            PWstat.Content = "";
            UN.IsEnabled = false;
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {

            PWstat.Content= "";
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var isValidated = hasNumber.IsMatch(PW.Text) && hasUpperChar.IsMatch(PW.Text) && hasMinimum8Chars.IsMatch(PW.Text) && hasLowerChar.IsMatch(PW.Text);
            if (isValidated && PW.Text == CP.Text)
            {
                Users User = new Users(UN.Text, PW.Text);
                WS.WebService1 ws = new WS.WebService1();
                ws.InsertUser(User.UN, User.PWD);
                ws.UpdateProfile(Pr.UN, Pr.Nick_Name, Pr.First_Name, Pr.Last_Name, Pr.Phone_Num, Pr.Profile_Pic);
                SingletonUser.GetSingleton(User);
                Window MS = new MainScW();
                MS.Show();
                this.Hide();
            }
            else if (isValidated && PW.Text != CP.Text)
            {
                PWstat.Content = "Passwords don't match.";
            }



        }

        private void PW_TextChanged(object sender, TextChangedEventArgs e)
        {
            PWstat.Content= "";
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasLowerChar = new Regex(@"[a-z]+");
            if (!hasNumber.IsMatch(PW.Text))
                PWstat.Content += "Password Doesn't Contain a number.\n";
            if (!hasUpperChar.IsMatch(PW.Text))
                PWstat.Content += "Password Doesn't Contain a capital charachter.\n";
            if (!hasMinimum8Chars.IsMatch(PW.Text))
                PWstat.Content += "Password must be at least 8 charachters long.\n";
            if (!hasLowerChar.IsMatch(PW.Text))
                PWstat.Content += "Password Doesn't Contain a small charachter.\n";
        }
    }
}
