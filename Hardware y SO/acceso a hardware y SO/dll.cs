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
using System.IO;

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

        public static string RAM()
        {
            ObjectQuery info = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher busqueda = new ManagementObjectSearcher(info);
            ManagementObjectCollection resultado = busqueda.Get();
            string Ram = "";
            foreach (ManagementObject Seleccion in resultado)
            {
                Ram += ($"Memoria Total Visible: {Convert.ToInt32(Seleccion["TotalVisibleMemorySize"]) / 1000} MB \n\r" +
                    $"Memoria Total Visible: {Convert.ToInt32(Seleccion["TotalVisibleMemorySize"]) / 1000} MB \n\r" +
                    $"Memoria Fisica Disponible: {Convert.ToInt32(Seleccion["FreePhysicalMemory"]) / 1000} MB \n\r" +
                    $"Memoria Total Virtual: {Convert.ToInt32(Seleccion["TotalVirtualMemorySize"]) / 1000} MB \n\r" +
                    $"Memoria Virtual Libre: {Convert.ToInt32(Seleccion["FreeVirtualMemory"]) / 1000} MB \n\r"
                    );
            }
            return Ram;
        }

        public static string unidadDisco()
        {
            DriveInfo[] Discos = DriveInfo.GetDrives();
            string discos = "";
            foreach (DriveInfo disk in Discos)
            {
                discos += ($"Drive {disk.Name} \n\r" +
                    $"Drive type: {disk.DriveType} \n\r"
                    );
                if (disk.IsReady == true)
                {
                    discos += ($"Etiqueta de volumen: {disk.VolumeLabel} \n\r" +
                        $"Sistema de archivos: {disk.DriveFormat} \n\r" +
                        $"Espacio disponible para el usuario actual: {Convert.ToDecimal(disk.AvailableFreeSpace) / 1073741824} GB \n\r" +
                        $"Espacio total disponible: {Convert.ToDecimal(disk.TotalFreeSpace) / 1073741824} GB \n\r" +
                        $"Tamaño total de la unidad: {Convert.ToDecimal(disk.TotalSize) / 1073741824} GB \n\r"
                        );
                }
            }
            return discos;
        }
    }
}       