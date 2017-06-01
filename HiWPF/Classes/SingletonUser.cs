using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class SingletonUser : Users
    {
        private static SingletonUser instance = null;
        private SingletonUser() { }
        private SingletonUser(Users x) : base(x.UN, x.PWD) { }
        public static SingletonUser GetSingleton(Users x)
        {
            if (instance == null)
            {
                instance = new SingletonUser(x);
                return instance;
            }
            return instance;
        }

    }
}
