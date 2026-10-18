using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Tarea
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bienBien = true;


            //Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre no puede estar vacio.");
                bienBien = false;
            }
            else
                errorProvider1.SetError(txtNombre, "");
            //Validar edad
            int edad;
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 0)
            {
                errorProvider1.SetError(txtEdad, "Debe ser un número mayor a 0");
                bienBien = false;
            }
            else
                errorProvider1.SetError(txtEdad, "");
            //Validar Curso

            if (string.IsNullOrWhiteSpace(txtCurso.Text))
            {
                errorProvider1.SetError(txtCurso, "El curso no puede estar vacio.");
                bienBien = false;
            }
            else
                errorProvider1.SetError(txtCurso, "");

            if (bienBien)
            {
                //El objeto estudiante
                Estudiante estudiante = new Estudiante();

                estudiante.Nombre = txtNombre.Text;
                estudiante.Edad = int.Parse(txtEdad.Text);
                estudiante.Curso = txtCurso.Text;

                estudiante.MostrarDatos();


            }



        }
    }
}

