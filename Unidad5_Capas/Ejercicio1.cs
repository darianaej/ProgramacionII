using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad5_Capas.BLL;

namespace Unidad5_Capas
{
    public partial class Ejercicio1 : Form
    {
        private ListaProducto listaProducto;

        public Ejercicio1()
        {
            InitializeComponent();
            listaProducto = new ListaProducto();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listaProducto.MostrarProducto();
        }
    }
}
