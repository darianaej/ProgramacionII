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
using Unidad5_Capas.DAL;

namespace Unidad5_Capas
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Desea guardar los cambios?",
        "Confirmación",
        MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                ListaProducto lista = new ListaProducto();

                foreach (Producto p in lista.MostrarProducto())
                {
                    MessageBox.Show(
                        $"Producto: {p.Nombre} - Precio: {p.Precio:C}");
                }
            }
            else
            {
                MessageBox.Show("Proceso cancelado.");
            }
        }
    }
}
