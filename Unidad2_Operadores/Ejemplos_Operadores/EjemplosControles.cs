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
    public partial class EjemplosControles : Form
    {
        public EjemplosControles()
        {
            InitializeComponent();
        }

        private void EjemplosControles_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rojo");
            listBox1.Items.Add("Morado");
            listBox1.Items.Add("Azul");

            listBox1.BackColor = Color.LightBlue;
            this.BackColor = Color.LightGray;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            listBox1.Items.Add("Se seleccionó Rojo");
        }

        private void btnMorado_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            listBox1.Items.Add("Se seleccionó Morado");
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            listBox1.Items.Add("Se seleccionó Azul"); 
        }
    }
}
