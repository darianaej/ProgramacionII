using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3.Tarea_Programada_3
{
    public partial class Tarea : Form
    {
        public Tarea()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int dia;

            dia = Convert.ToInt32(txtDia.Text);
            switch (dia)
            {
                case 1: MessageBox.Show("Lunes"); break;
                case 2: MessageBox.Show("Martes"); break;
                case 3: MessageBox.Show("Miércoles"); break;
                case 4: MessageBox.Show("Jueves"); break;
                case 5: MessageBox.Show("Viernes"); break;
                case 6: MessageBox.Show("Sábado"); break;
                case 7: MessageBox.Show("Domingo"); break;
                default:
                    MessageBox.Show("Error: Opción no válida", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            

        }

        private void Tarea_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro de salir del programa?", "Confirmación de salida",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
