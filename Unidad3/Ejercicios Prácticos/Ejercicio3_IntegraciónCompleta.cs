using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3
{
    public partial class Ejercicio3_IntegraciónCompleta : Form
    {
        public Ejercicio3_IntegraciónCompleta()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
                int numero = Convert.ToInt32(txtNumero.Text);
                switch (numero)
                {
                    case 1: MessageBox.Show("Seleccionaste la opción 1"); break;
                    case 2: MessageBox.Show("Seleccionaste la opción 2"); break;
                    case 3: MessageBox.Show("Seleccionaste la opción 3"); break;
                    case 4: MessageBox.Show("Seleccionaste la opción 4"); break;
                    default:
                        DialogResult resultado = MessageBox.Show("Error: Opción no válida", "Error",
                                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (resultado == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                }
        }
    }
}
