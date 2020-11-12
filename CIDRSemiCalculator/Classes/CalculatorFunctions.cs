using System.Linq;
using System.Net;
using LukeSkywalker.IPNetwork;


namespace CIDRSemiCalculator.Classes
{
    /// <summary>
    /// A ip/cidr calculator with 3 functions that actually work.
    /// </summary>
    public static class CalculatorFunctions
    {
        /// <summary>
        /// Returns whether the CIDR is in the right format.
        /// </summary>
        public static bool ValidCIDR(string cidr)
        {
            if (ValidIPv4(cidr.Split('/')[0])) //Make sure we only use IPv4 and not IPv6
            {
                try //In case the mask is in a wrong format.
                {
                    //IPNetwork automatically converts the CIDR to the correct format. 
                    IPNetwork net = IPNetwork.Parse(cidr); 
                    
                    if (net.ToString() == cidr) //If no correction was made then the format was correct.
                    {
                        return true;
                    }
                    else //If a correction was made.
                        return false;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the CIDR range in a First:Last string format.
        /// </summary>
        public static string CalculateCIDRRange(string cidr)
        {
            IPNetwork net = IPNetwork.Parse(cidr);
            if (ValidCIDR(cidr))
            {
                //There's also an option to get first/last useable addresses but it involves an ugly conversion code.
                string firstIP = net.Network.ToString();
                string lastIP = net.Broadcast.ToString();

                return firstIP + ":" + lastIP;
            }

            return "BAD";
        }
        /// <summary>
        /// Checks whether two ip ranges (networks) overlap.
        /// </summary>
        public static bool CIDROverlaps(string cidr1, string cidr2)
        {
            IPNetwork net1 = IPNetwork.Parse(cidr1);
            IPNetwork net2 = IPNetwork.Parse(cidr2);

            bool net1Contains=IPNetwork.Contains(net1, net2.Network) || IPNetwork.Contains(net1, net2.Broadcast);
            bool net2Contains=IPNetwork.Contains(net2, net1.Network) || IPNetwork.Contains(net2, net1.Broadcast);


            if (net1Contains|| net2Contains)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This function makes sure the IPNetwork library doesn't work with IPv6 adresses.
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
