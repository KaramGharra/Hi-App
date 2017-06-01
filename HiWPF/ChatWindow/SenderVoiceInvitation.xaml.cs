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
using System.Windows.Shapes;

namespace HiWPF.ChatWindow
{
    /// <summary>
    /// Interaction logic for SenderVoiceInvitation.xaml
    /// </summary>
    public partial class SenderVoiceInvitation : Window
    {
        public string Target;
        public SenderVoiceInvitation()
        {
            InitializeComponent();
        }
        public SenderVoiceInvitation(string cont) {

            WS.WebService1 ws = new WS.WebService1();
            Target = cont;
            ws.SendInvitationAsync(SingletonUser.GetSingleton(null).UN, cont, "Voice");
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            WS.WebService1 ws = new WS.WebService1();
            ws.DeleteInvitation(SingletonUser.GetSingleton(null).UN,Target);
            Close();
        }
    }
}
