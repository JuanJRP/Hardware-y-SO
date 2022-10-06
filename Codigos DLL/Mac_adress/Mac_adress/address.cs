using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mac_adress
{
    public class address
    {
        public void Mac_adress ()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces ();
            string sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            { 
                if (sMacAddress == string.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties ();
                    sMacAddress = adapter.GetPhysicalAddress().ToString ();
                }
            }
        }
        
       

    }
}
