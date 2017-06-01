using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HiWPF.Classes
{
    public class Getters{
        public static long offsetPort = 5000;
        public static long Port() { return offsetPort; }
        public static IPAddress GetIPAddress()
        {
            IPAddress[] hostAddresses = Dns.GetHostAddresses("");

            foreach (IPAddress hostAddress in hostAddresses)
            {
                if (hostAddress.AddressFamily == AddressFamily.InterNetwork &&
                    !IPAddress.IsLoopback(hostAddress) &&  // ignore loopback addresses
                    !hostAddress.ToString().StartsWith("169.254."))  // ignore link-local addresses
                    return hostAddress;
            }
            return IPAddress.None; 
        }
        public static List<Users> GetContacts() {
            WS.WebService1 ws = new WS.WebService1();
            List<Users> Contacts = new List<Users>();
            foreach (WS.Users c in ws.getContacts(SingletonUser.GetSingleton(new Users()).UN))
                Contacts.Add(new Users(c.UN));
            return Contacts;
        }
        public static List<GroupInfo> GetGroups() {
            WS.WebService1 ws = new WS.WebService1();
            List<GroupInfo> Groups = new List<GroupInfo>();
            foreach (WS.GroupInfo g in ws.GetGroupsByParticipant(SingletonUser.GetSingleton(new Users()).UN))
                Groups.Add(new GroupInfo(g.G_Name, g.Creator, g.G_Pic, g.NumOfParticipants));
            return Groups;
        }

        public static Profile GetUserProfile(string UN)
        {
            WS.WebService1 ws = new WS.WebService1();
            WS.Profile x = ws.getProfile(UN);
            return new Profile(x.UN,
                                      x.Nick_Name,
                                      x.First_Name,
                                      x.Last_Name,
                                      x.Phone_Num,
                                      x.Profile_Pic);
        }

    }
}
