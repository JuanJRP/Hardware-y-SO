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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;


namespace acceso_a_hardware_y_SO
{
    public partial class Inicio : Form
    {
        /*-------------------------------------------------Funciones---------------------------------------------------------*/
        List<string> Proceso = new List<string>();

        public void Ocultar()
        {
            rtbInformacion.Visible = true;
            lvwInformacion.Visible = false;
            plFinalizar.Visible = false;
        }
        
        public void General()
        {
            Ocultar();
            rtbInformacion.Text = (
                $"Informacion General Del Sistema \n\r" +
                $"Serial HDD:  {Informacion.Serial_HDD()} \n\r" +
                $"Unidades de Disco:  \n\r" +
                $"Serial CD:  {Informacion.Serial_CD()} \n\r" +
                $"Serial DVD:  {Informacion.Serial_CD()} \n\r" + 
                $"Procesadores: {Informacion.Procesadores().ToString()} \n\r" +
                $"Memoria Ram: \n\r" 
                );
        }

        public void Balance()
        {
            Ocultar();
            rtbInformacion.Text = (
                $"Balance General Del Sistema \n\r" +
                $"NICS: \n\r{Informacion.targetasRed()} \r" +
                $"Mac Address: \n\r{Informacion.macAddress()} \n\r" +
                $"Patches: \n\r{Informacion.Patches()}"
                );
        }

        public void Registro()
        {
        }

        public void Procesos()
        {
            lvwInformacion.Items.Clear();
            rtbInformacion.Visible = false;
            lvwInformacion.Visible = true;
            List<decimal> MB = new List<decimal>();
            Proceso = Informacion.Procesos();
            MB = Informacion.ProcesosMB();
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < Proceso.Count(); i++)
            {
                item = lvwInformacion.Items.Add((i + 1).ToString());
                item.SubItems.Add(Proceso[i]);
                item.SubItems.Add(MB[i].ToString());
            }
        }
        /*-------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------InitializeComponent-----------------------------------------------*/

        public Inicio()
        {
            InitializeComponent();
            General();
        }
        /*-------------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------------Botones---------------------------------------------------------*/

        private void cmdGeneral_Click(object sender, EventArgs e)
        {
            General();
        }
        private void cmdBalance_Click(object sender, EventArgs e)
        {
            Balance(); 
        }

        private void cmdRegistro_Click(object sender, EventArgs e)
        {
            Registro();
        }

        private void cmdProcesos_Click(object sender, EventArgs e)
        {
            Procesos();
            plFinalizar.Visible = true;
        }
        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvwInformacion.SelectedItems[0];
            string nombre = Proceso[Convert.ToInt32(item.Text) - 1];
            nombre = nombre.Replace(" ",string.Empty);
            string subnombre = nombre.Substring(0, nombre.Length - 2);
            Informacion.ProcesosKill(subnombre);
            Procesos();
        }

        private void cmdInformacion_Click(object sender, EventArgs e)
        {
            DialogResult mb = MessageBox.Show("Juan Jose Restrepo Pabon \n\n Mildrey Yurany Velazques \n\n Josue David Kerguelen \n\n Juliana Jaramillo Mendez", "Creadores", MessageBoxButtons.OK);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*-------------------------------------------------------------------------------------------------------------------*/
    }
}