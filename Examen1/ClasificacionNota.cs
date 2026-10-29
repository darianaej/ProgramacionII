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
    public partial class ClasificacionNota : Form
    {
        public ClasificacionNota()
        {
            InitializeComponent();
        }

        private void ClasificacionNota_Load(object sender, EventArgs e)
        {
            listCategoria.Items.Add("Excelente");
            listCategoria.Items.Add("Muy Bueno");
            listCategoria.Items.Add("Bueno");
            listCategoria.Items.Add("Regular");
            listCategoria.Items.Add("Deficiente");
        }

        private string CalcularCategoria(double nota)
        {
            if (nota >= 90 && nota <= 100)
            {
                return "Excelente";
            }
            else if (nota >= 80 && nota <= 89)
            {
                return "Muy Bueno";
            }
            else if (nota >= 70 && nota <= 79)
            {
                return "Bueno";
            }
            else if (nota >= 60 && nota <= 69)
            {
                return "Regular";
            }
            else
            {
                return "Deficiente";
            }
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double nota =Convert.ToDouble(txtNota.Text);

            string categoria = CalcularCategoria(nota);

            lblResultado.Text = categoria;

            if (nota >= 90)
            {
                lblResultado.BackColor = Color.LightGreen;
            }
            else if (nota >= 60)
            {
                lblResultado.BackColor = Color.LightYellow;
            }
            else
            {
                lblResultado.BackColor = Color.Red;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota.Clear();
            lblResultado.Text = "";
            lblResultado.BackColor = SystemColors.Window;
            listCategoria.ClearSelected();
        }
    }
}
