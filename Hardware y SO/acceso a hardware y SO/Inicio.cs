using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;

namespace acceso_a_hardware_y_SO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            lblHDDinfo.Text = N_Serial();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        class HardDrive
        {
            private string serialNo = null;
            public string SerialNo
            {
                get { return serialNo; }
                set { serialNo = value; }
            }
        }
        static string N_Serial()
        {
            ArrayList HDD = new ArrayList();
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject Serial in MOS.Get())
            {
                HardDrive hd = new HardDrive();
                hd.SerialNo = Serial["SerialNumber"].ToString();
                HDD.Add(hd);
                return hd.SerialNo;
            }
            return "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mb = MessageBox.Show("Integrantes: \n\n Juan Jose Restrepo Pabon \n Mildrey Yurany Velazques \n Josue David Kerguelen \n Juliana Jaramillo","Creadores.", MessageBoxButtons.OK);
        }
    }
}
