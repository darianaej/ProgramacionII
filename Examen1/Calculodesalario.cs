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
    public partial class Calculodesalario : Form
    {
        public Calculodesalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            double horas = Convert.ToDouble(txtHorastrabajadas.Text);
            if (horas <= 0) 
            {
                MessageBox.Show("Ingrese una cantidad mayor que 0");
                return;
            }
            double pagohora = Convert.ToDouble(txtPagoporhora.Text);
            if (pagohora <= 0)
            {
                MessageBox.Show("Ingrese un número mayor que 0");
            }

            double salario = 0;
            if (horas <= 40)
            {
                salario = horas * pagohora;
            }
            else
            {
                double horasAdi = horas - 40;
                salario = (40 * pagohora) + (horasAdi * pagohora * 1.5);
            }
            lblResultado.Text = "Nombre: " + nombre + "\nSalario: " + salario;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHorastrabajadas.Clear();
            txtPagoporhora.Clear();
            lblResultado.Text = "";
        }
    }
}
