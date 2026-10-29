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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            bool correcto = true;

            // Validar código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "El código no puede estar vacío.");
                correcto = false;
            }
            else
                errorProvider1.SetError(txtCodigo, "");

            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.");
                correcto = false;
            }
            else
                errorProvider1.SetError(txtNombre, "");

            // Validar precio
            double precio;

            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio, "Debe ser un número mayor que 0.");
                correcto = false;
            }
            else
                errorProvider1.SetError(txtPrecio, "");

            if (correcto)
            {
                Producto producto = new Producto();

                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = precio;

                MessageBox.Show(
                    "Código: " + producto.Codigo +
                    "\nNombre: " + producto.Nombre +
                    "\nPrecio: ₡" + producto.Precio +
                    "\nPrecio con IVA: ₡" + producto.ObtenerPrecioConIVA()
                );
            }
        }
    }
}
