using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class Users
    {
        public Users() { }

        public Users(string uN) { this.UN = uN; }

        public Users(String uN, String pWD)
        {
            UN = uN;
            PWD = pWD;
        }

        public String UN;
        public String PWD;

        public String GetUN() { return UN; }
        public String getPWD() { return PWD; }


    }
}
