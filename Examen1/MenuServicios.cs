using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class MenuServicios : Form
    {
        public MenuServicios()
        {
            InitializeComponent();
        }

        private void MenuServicios_Load(object sender, EventArgs e)
        {
            cmbServicios.Items.Add("Instalación de software");
            cmbServicios.Items.Add("Mantenimiento");
            cmbServicios.Items.Add("Soporte técnico");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int precio = 0;

            switch (cmbServicios.Text)
            {
                case "Instalación de software":
                    precio = 15000;
                    break;

                case "Mantenimiento":
                    precio = 20000;
                    break;

                case "Soporte técnico":
                    precio = 10000;
                    break;

                default:
                    MessageBox.Show("Seleccione un servicio");
                    return;
            }

            MessageBox.Show("Precio del servicio: ₡" + precio);
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbServicios.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
