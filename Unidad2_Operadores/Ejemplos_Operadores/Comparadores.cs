using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_Operadores.Ejemplos_Operadores
{
    public partial class Comparadores : Form
    {
        public Comparadores()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            if (num1 > num2)
            {
                MessageBox.Show("El primer número es mayor.");
            }
            else if (num2 > num1)
            {
                MessageBox.Show("El segundo número es mayor");
            }
            else
            {
                MessageBox.Show("Ambos números son iguales.");
            }

        }
    }
}
