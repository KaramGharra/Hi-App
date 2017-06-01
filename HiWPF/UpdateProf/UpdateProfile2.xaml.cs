using HiWPF.Classes;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HiWPF
{
    /// <summary>
    /// Interaction logic for UpdateProfile.xaml
    /// </summary>
    public partial class UpdateProfile2 : UserControl
    {
        public UpdateProfile2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            SingletonChats.GetSingleton(null).Pchanged = false;
            Window.GetWindow(this).Close();
        }

        private void PP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true){
                PP.Fill = new ImageBrush(new BitmapImage(new Uri(op.FileName)));
                SingletonChats.GetSingleton(new Chats()).Prof.Profile_Pic = op.FileName;
            } 
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SingletonChats.GetSingleton(null).Pchanged = true;
            Profile X = SingletonChats.GetSingleton(new Chats()).Prof;
            X.UN = SingletonUser.GetSingleton(null).UN;
            X.Nick_Name = NN.Text;
            X.First_Name = FN.Text;
            X.Last_Name = LN.Text;
            X.Phone_Num = PN.Text;
            WS.WebService1 ws = new WS.WebService1();
            string res = ws.UpdateProfile(X.UN, X.Nick_Name, X.First_Name, X.Last_Name, X.Phone_Num, X.Profile_Pic);
            if (res == "Profile Updated")
                MessageBox.Show("Profile Updated", "Updating Result", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            Window.GetWindow(this).Close();
        }
    }
}
