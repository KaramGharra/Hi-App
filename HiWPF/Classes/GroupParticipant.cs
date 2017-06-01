using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    class GroupParticipant
    {
        public int G_Name;
        public string Creator;
        public string Participant;

        public GroupParticipant() { }

        public GroupParticipant(int g_Name, string creator, string participant)
        {
            G_Name = g_Name;
            Creator = creator;
            Participant = participant;
        }
    }
}
