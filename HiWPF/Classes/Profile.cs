using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class Profile
    {
        public Profile() { }
        public Profile(string uN)
        {
            UN = uN;
        }

        public Profile(string uN, string nick_Name)
        {
            UN = uN;
            Nick_Name = nick_Name;
        }

        public Profile(string uN, string nick_Name, string first_Name)
        {
            UN = uN;
            Nick_Name = nick_Name;
            First_Name = first_Name;
        }

        public Profile(string uN, string nick_Name, string first_Name, string last_Name, string phone_Num)
        {
            UN = uN;
            Nick_Name = nick_Name;
            First_Name = first_Name;
            Last_Name = last_Name;
            Phone_Num = phone_Num;
        }

        public Profile(string uN, string nick_Name, string first_Name, string last_Name, string phone_Num, string profile_Pic)
        {
            UN = uN;
            Nick_Name = nick_Name;
            First_Name = first_Name;
            Last_Name = last_Name;
            Phone_Num = phone_Num;
            Profile_Pic = profile_Pic;
        }

        public string UN { get; set; }
        public string Nick_Name { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone_Num { get; set; }
        public string Profile_Pic { get; set; }
    }
}
