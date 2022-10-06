using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;


namespace serial_CD
{
     internal class dl
     {
        public static string serial_cd()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["SerialCD"].ToString();
                }
            }
            catch
            {
                return "";
            }
            return "";



        }
     }

    
}
