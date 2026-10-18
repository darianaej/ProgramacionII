using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Tarea
{
    public class Estudiante
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int edad;
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0 && value <= 120)
                    edad = value;
                else
                    MessageBox.Show("Edad Invalida");
            }
        }
        private string curso;
        public string Curso
        {
            get { return curso; }
            set { curso = value;  }
        }

        public void MostrarDatos()
        {
            MessageBox.Show("Nombre: " + Nombre + "\nEdad: " + Edad + "\nCurso: " + Curso);
        }
    }
}
