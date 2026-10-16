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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();

            producto1.Nombre = "Perfume";
            producto1.Precio = 500;

            producto1.MostrarInformacion();
        }
    }
}
