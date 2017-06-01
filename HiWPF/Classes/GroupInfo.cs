using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class GroupInfo
    {

        public string G_Name;
        public string Creator;
        public string G_Pic;
        public int NumOfParticipants;


        public GroupInfo() { }

        public GroupInfo(string g_Name, int numOfParticipants)
        {
            G_Name = g_Name;
            NumOfParticipants = numOfParticipants;
        }
        public GroupInfo(string g_Name, string Creator)
        {
            G_Name = g_Name;
            this.Creator = Creator;
        }
        public GroupInfo(string g_Name, string creator, int numOfParticipants)
        {
            G_Name = g_Name;
            Creator = creator;
            NumOfParticipants = numOfParticipants;
        }

        public GroupInfo(string g_Name, string creator, string g_Pic, int numOfParticipants)
        {
            G_Name = g_Name;
            Creator = creator;
            G_Pic = g_Pic;
            NumOfParticipants = numOfParticipants;
        }
        public GroupInfo(GroupInfo g)
        {
            G_Name = g.G_Name;
            Creator = g.Creator;
            G_Pic = g.G_Pic;
            NumOfParticipants = g.NumOfParticipants;
        }



        public void setGNAME(string G_N) { G_Name = G_N; }
        public void setImage(string G_P) { G_Pic = G_P; }
        public void setNumofParticipants(int Participants) { NumOfParticipants = Participants; }

        public string getG_Name() { return G_Name; }
        public string getIMG() { return G_Pic; }
        public int getNumOfParticipants() { return NumOfParticipants; }

    }
}
