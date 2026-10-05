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
    public partial class EjemploOperadores : Form
    {
        public EjemploOperadores()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            int a = 10;
            int b = 5;

            //Operador relacional
            bool resultado = a > b;

            //operador aritmético
            int suma = a + b;
            int modulo = a % b;

            bool condicion = (a > b) && (b > 0);

            MessageBox.Show("¿a es mayor que b? " + resultado);
            MessageBox.Show("La suma de a + b es: " + suma);
            MessageBox.Show("El residuo de a % b es: " + modulo);
            MessageBox.Show("¿(a>b) Y (b>0)? " + condicion);
        }
    }
}
