using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class Chats
    {
        public List<Users> Cchats;
        public List<GroupInfo> Gchats;
        public int changed = 0;
        public Users OpenChatFromSearch = null;
        public GroupInfo OpenGroupFromSearch = null;
        public Profile Prof = null;
        public bool Pchanged = false;
        public Chats()
        {
            Cchats = new List<Users>();
            Gchats = new List<GroupInfo>();
            changed = 0;
        }
        public Chats(List<Users> c, List<GroupInfo> g)
        {
            Cchats = c;
            Gchats = g;
            changed = 0;
        }
        public List<Users> GetCchats() { return Cchats; }
        public List<GroupInfo> getGchats() { return Gchats; }
    }
}
