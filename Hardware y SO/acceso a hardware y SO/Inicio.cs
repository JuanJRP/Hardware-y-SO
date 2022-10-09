using System;
using System.Data;
using System.Linq;
using System.Text;
using Infromacion;
using System.Drawing;
using System.Management;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Management.Instrumentation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace acceso_a_hardware_y_SO
{
    public partial class Inicio : Form
    {
        /*-------------------------------------------------Funciones---------------------------------------------------------*/
        List<string> Proceso = new List<string>();

        public void Ocultar()
        {
            lblRuta.Visible = false;
            txtRuta.Visible = false;
            cmdLeer.Visible = false;
            txtNombre.Visible = false;
            lblNombre.Visible = false;
            plFinalizar.Visible = false;
            rtbInformacion.Visible = true;
            lvwInformacion.Visible = false;
        }
        
        public void General()
        {
            Ocultar();
            rtbInformacion.Text = (
                $"Informacion General Del Sistema \n\r" +
                $"Serial HDD:  {Informacion.Serial_HDD()} \n\r" +
                $"Serial CD:  {Informacion.Serial_CD()} \n\r" +
                $"Serial DVD:  {Informacion.Serial_CD()} \n\r" + 
                $"Procesadores: {Informacion.Procesadores().ToString()} \n\n\r" +
                $"Memoria Ram  \n\r{Informacion.RAM()}\n\r" +
                $"Unidades de Disco \n\r{Informacion.unidadDisco()} " 

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
            lblRuta.Visible = true;
            txtRuta.Visible = true;
            cmdLeer.Visible = true;
            txtNombre.Visible = true;
            lblNombre.Visible = true;
            plFinalizar.Visible = false;
            rtbInformacion.Visible = false;
            lvwInformacion.Visible = false;
        }

        public void Procesos()
        {
            lvwInformacion.Items.Clear();
            lblRuta.Visible = false;
            txtRuta.Visible = false;
            cmdLeer.Visible = false;
            txtNombre.Visible = false;
            lblNombre.Visible = false;
            lvwInformacion.Visible = true;
            rtbInformacion.Visible = false;
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
            plRegedit.Visible = false;
            txtNombre.Clear();
            txtRuta.Clear();
        }
        private void cmdLeer_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtRuta.Text != "")
            {
                Ocultar();
                rtbInformacion.Text = ($"Editor del Registro de sistema\n\n" +
                    $"Ruta/Dirreccion: {txtRuta.Text}\n\n" +
                    $"Nombre de la Llave: {txtNombre.Text}\n\n\n" +
                    $"Valor que contiene la Llave: {Informacion.Regedit(txtRuta.Text, txtNombre.Text,1)}"
                );
                plRegedit.Visible = true;
            }
            else { MessageBox.Show("Complete la informacion solicitada."); }
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            Ocultar();
            lblCrud.Visible = true;
            cmdCRUD.Visible = true;
            txtCrud.Visible = true;
            plRegedit.Visible = true;
            rtbInformacion.Visible = false;
            lblCrud.Text = "Ingrese el nombre de la llave a Crear";
            cmdCRUD.Text = "Crear";
            txtCrud.Clear();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            Ocultar();
            lblCrud.Visible = true;
            cmdCRUD.Visible = true;
            txtCrud.Visible = true;
            plRegedit.Visible = true;
            rtbInformacion.Visible = false;
            lblCrud.Text = "Ingrese el nombre de la llave a Editar";
            cmdCRUD.Text = "Editar";
            txtCrud.Clear();
        }

        private void cmdCRUD_Click(object sender, EventArgs e)
        {
            switch (cmdCRUD.Text)
            {
                case "Editar":
                    if (txtNombre.Text != "" && txtRuta.Text != "" && txtCrud.Text != "")
                    {
                        Ocultar();
                        rtbInformacion.Text = ($"Editor del Registro de sistema\n\n" +
                            $"Ruta/Dirreccion: {txtRuta.Text}\n\n" +
                            $"Nombre de la Llave: {txtNombre.Text}\n\n\n" +
                            $"Valor que contiene la Llave: {Informacion.Regedit(txtRuta.Text, txtNombre.Text, 2, txtCrud.Text)}"
                        );
                    }
                    else { MessageBox.Show("Complete la informacion solicitada."); }
                    break;

                case "Crear":
                    if (txtNombre.Text != "" && txtRuta.Text != "" && txtCrud.Text != "")
                    {
                        Ocultar();
                        rtbInformacion.Text = ($"Editor del Registro de sistema\n\n" +
                            $"Ruta/Dirreccion: {txtRuta.Text}\n\n" +
                            $"Nombre de la Llave: {txtCrud.Text}\n\n\n" +
                            $"Valor que contiene la Llave: {Informacion.Regedit(txtRuta.Text, txtCrud.Text, 3)}"
                        );txtNombre.Text = txtCrud.Text;
                    }
                    else { MessageBox.Show("Complete la informacion solicitada."); }
                    break;
            }
            cmdCRUD.Visible = false;
            lblCrud.Visible = false;
            txtCrud.Visible = false;
        }

        private void cmdProcesos_Click(object sender, EventArgs e)
        {
            Procesos();
            plFinalizar.Visible = true;
        }
        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            if (lvwInformacion.SelectedIndices.Count != 0)
            {
                ListViewItem item = lvwInformacion.SelectedItems[0];
                string nombre = Proceso[Convert.ToInt32(item.Text) - 1];
                nombre = nombre.Replace(" ", string.Empty);
                string subnombre = nombre.Substring(0, nombre.Length - 2);
                Informacion.ProcesosKill(subnombre);
                Procesos();
            }
            else { MessageBox.Show("Seleccione un proceso."); }
            
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