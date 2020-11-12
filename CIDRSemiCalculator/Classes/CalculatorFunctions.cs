using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LukeSkywalker.IPNetwork;

namespace CIDRSemiCalculator.Classes
{
    public static class CalculatorFunctions
    {

        public static bool ValidCIDR(string cidr)
        {
            if (ValidIPv4(cidr.Split('/')[0])) //Make sure we only use IPv4 and not IPv6
            {
                try
                {
                    IPNetwork net = IPNetwork.Parse(cidr);
                    if (net.ToString() == cidr)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }


        public static string CalculateCIDRRange(string cidr)
        {
            IPNetwork net = IPNetwork.Parse(cidr);
            if (ValidCIDR(cidr))
            {
                //Since the way we can get the range is only from first/last usable addresses, we'll dec/inc them by 1.
                //Get the first/last usable.
                string firstIP= net.FirstUsable.ToString();
                string lastIP = net.LastUsable.ToString();

                //Get the last char from the addresses above. Decrement the first, increment the last. -'0' converts to int.
                int changeFirst = firstIP[firstIP.Length - 1] - '0' - 1;
                int changeLast = lastIP[lastIP.Length - 1] - '0' + 1;

                //Remove the wrong last char and chain the correct one.
                firstIP = firstIP.Remove(firstIP.Length - 1, 1) + changeFirst.ToString();
                lastIP = lastIP.Remove(lastIP.Length - 1, 1) + changeLast.ToString();


                return firstIP + ":" + lastIP;
            }

            return "BAD";
        }

        public static bool CIDROverlaps(string cidr1, string cidr2)
        {
            IPNetwork net1 = IPNetwork.Parse(cidr1);
            IPNetwork net2 = IPNetwork.Parse(cidr2);
            
            if(net1.CompareTo(net2)>0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This functions makes sure the IPNetwork library doesn't work with IPv6 adresses.
        /// </summary>
        private static bool ValidIPv4(string cidr)
        {
            IPAddress ip = IPAddress.Parse("::1"); //Initializing with an actual IPv6 to make sure the value changes.
            if (cidr.Count(c => c == '.') == 3)
            {
                bool isParseable = IPAddress.TryParse(cidr, out ip);
                if (isParseable)
                {
                    //Making sure it's an IPv4 address. (Line take from our DS project where we did the same thing).
                    if (ip.AddressFamily.ToString() == System.Net.Sockets.ProtocolFamily.InterNetwork.ToString())
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

    }
}
