using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Practicas
{
    public partial class Ejercicio2 : Form
    {
        private int precio;

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre Invalido");
                return;
            }

            
            if (!int.TryParse(txtPrecio.Text, out int precio) || precio < 0)
            {
                MessageBox.Show("Precio Invalido");
                return;
            }

            MessageBox.Show("Estos datos son correctos");
        }

    }
    
}
