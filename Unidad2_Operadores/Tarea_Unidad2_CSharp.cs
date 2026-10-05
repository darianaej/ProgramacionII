using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad2_Operadores
{
    public partial class Tarea_Unidad2_CSharp : Form
    {
        public Tarea_Unidad2_CSharp()
        {
            InitializeComponent();
            // Asignar el ContextMenuStrip al formulario y a los controles relevantes
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.txtNumero1.ContextMenuStrip = this.contextMenuStrip1;
            this.txtNumero2.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;

            // Registrar manejadores de los items del menú si no están enlazados en el diseñador
           // this.cambiarElFondoToolStripMenuItem.Click += cambiarElFondoToolStripMenuItem_Click;
            this.salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        }
        
            

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                if (numero1 > numero2)
                {
                    MessageBox.Show(numero1.ToString(), "El número 1 es mayor");
                }
                else if (numero2 > numero1)
                {
                    MessageBox.Show(numero2.ToString(), "El número 2 es mayor");
                }
                else
                {
                    MessageBox.Show("Son iguales", "Resultado");
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            string seleccionado = listBox1.SelectedItem.ToString().Trim();
            Color nuevoColor = Color.Empty;

            switch (seleccionado)
            {
                case "Azul":
                    nuevoColor = Color.Blue;
                    break;
                case "Marrón":
                case "Marron":
                    nuevoColor = Color.Brown;
                    break;
                case "Morado":
                    nuevoColor = Color.Purple;
                    break;
                case "Rojo":
                    nuevoColor = Color.Red;
                    break;
                default:
                    // Intentar usar el nombre del color directamente (insensible a mayúsculas)
                    nuevoColor = Color.FromName(seleccionado);
                    break;
            }
            if (nuevoColor.IsEmpty)
            {
                MessageBox.Show($"Color desconocido: '{seleccionado}'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.BackColor = nuevoColor;

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cambiarDeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
