using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class Messages
    {
        public string Sender;
        public string Reciver;
        public string Message;
        public string Status;
        public string Date;

        public Messages() { }

        public Messages(string sender, string reciver, string message, string date, string status)
        {
            Sender = sender;
            Reciver = reciver;
            Message = message;
            Date = date;
            Status = status;
        }
    }
}
