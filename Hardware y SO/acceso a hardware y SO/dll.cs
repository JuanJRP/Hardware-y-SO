using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using WUApiLib;
using System.Diagnostics;
using System.Windows.Forms;

namespace acceso_a_hardware_y_SO
{
    internal class Informacion
    {
        public static string Serial_HDD()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject queryObj in searcher.Get()) { return queryObj["SerialNumber"].ToString(); }
            } catch { return ""; } return "";
        }

        public static string targetasRed()
        {
            string nombres = "";
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters) { nombres += adapter.Description + "\n\n"; }
            return nombres;
        }

        public static string macAddress()
        {
            string nombres = "";
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters) { nombres += adapter.Description + ": " + adapter.GetPhysicalAddress() + "\n\n"; }
            return nombres;
        }

        public static string Serial_CD()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
                foreach (ManagementObject queryObj in searcher.Get()) { return queryObj["SerialCD"].ToString(); }
            }
            catch { return "No hay instancias disponibles."; }
            return "No hay instancias disponibles.";
        }
        public static int Procesadores()
        {
            return Environment.ProcessorCount;
        }
        public static string Patches()
        {
            var updateSession = new UpdateSession();
            var updateShearcher = updateSession.CreateUpdateSearcher();
            var count = updateShearcher.GetTotalHistoryCount();
            var History = updateShearcher.QueryHistory(0, count);
            string titulos = "";
            for (int i = 0; i < count; i++) { titulos += History[i].Title + "\n\r"; }
            return titulos;
        }

        public static List<string> Procesos()
        {
            List<string> Proceso = new List<string>();
            Process[] listaProcesos = Process.GetProcesses();
            foreach (Process procesos in listaProcesos) { Proceso.Add(procesos.ProcessName + "\n\r"); }
            return Proceso;
        }
        public static List<decimal> ProcesosMB()
        {
            List<decimal> MB = new List<decimal>();
            Process[] listaProcesos = Process.GetProcesses();
            foreach (Process procesos in listaProcesos)
            {
                MB.Add(procesos.PeakPagedMemorySize64 / 1048576);
            }
            return MB;
        }

        public static void ProcesosKill(string Nombre = "")
        {
            try
            {
                Process[] procesos = Process.GetProcessesByName(Nombre);
                foreach (Process proceso in procesos) { proceso.Kill(); }
            }
            catch { }
        }
    }
}       