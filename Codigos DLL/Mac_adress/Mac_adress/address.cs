using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mac_adress
{
    internal class address
    {

        public static string Mac()
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                string sMacAddress = "";
                foreach (NetworkInterface adapter in nics)
                {
                    
                   sMacAddress += adapter.GetPhysicalAddress().ToString();
                   
                    
                }
                return sMacAddress;
            }
           catch
            {
                return "No hay instacias.";
            }

        }
        
    }
}
