using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Controles
{
    public partial class Form_Multiplicar : Form
    {
        public Form_Multiplicar()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = double.Parse(txtNumero1.Text);
                double numero2 = double.Parse(txtNumero2.Text);
                double resultado = numero1 * numero2;
                lblResultado2.Text = "Resultado: " + resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa dons numeros validos.");
            }
        }
    }
}
