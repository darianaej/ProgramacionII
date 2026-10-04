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
    public partial class Form_Sumar : Form
    {
        public Form_Sumar()
        {
            InitializeComponent();
        }



        private void Sumar1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            // Leer desde los TextBox (txtNumero1, txtNumero2)
            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese dos números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
} 

