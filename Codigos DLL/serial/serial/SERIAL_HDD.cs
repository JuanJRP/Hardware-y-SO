using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace serial
{
    internal class SERIAL_HDD
    {
        public static string SERIAL()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["SerialNumber"].ToString();
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
