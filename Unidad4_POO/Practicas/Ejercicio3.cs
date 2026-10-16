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
    public partial class Ejercicio3 : Form
    {
        bool bienBien = true;
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacio");
                bienBien = true; //no permite salir hasta corregir
            }
            else
                errorProvider1.SetError(txtNombre, "");

            int precio;
            if (!int.TryParse(txtPrecio.Text, out precio) || precio < 0)
            {
                errorProvider1.SetError(txtPrecio, "Precio Invalido");
            }
            else
                errorProvider1.SetError(txtPrecio, "");
        }
    }
}
