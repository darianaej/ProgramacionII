using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad5_Capas.DAL;

namespace Unidad5_Capas
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();

            estudiante.AñoNacimiento = 2004;

            MessageBox.Show(
                $"Año de nacimiento: {estudiante.AñoNacimiento}\n" +
                $"Edad calculada: {estudiante.EdadCalculada}");
        }
    }
}
