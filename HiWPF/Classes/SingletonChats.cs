using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class SingletonChats : Chats
    {
        private static SingletonChats instance = null;
        private SingletonChats() { }
        private SingletonChats(Chats x) : base(x.Cchats, x.Gchats) { }
        public static SingletonChats GetSingleton(Chats x)
        {
            if (instance == null)
            {
                instance = new SingletonChats(x);
                return instance;
            }
            return instance;
        }

    }
}
