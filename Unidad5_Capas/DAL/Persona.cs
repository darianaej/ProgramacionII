using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad5_Capas.DAL
{
    // Clase base
    public class Persona
    {
        private int añoNacimiento;

        public int AñoNacimiento
        {
            get { return añoNacimiento; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    añoNacimiento = value;
                else
                    throw new ArgumentException("Año de nacimiento inválido");
            }
        }
    }
    // Clase derivada
    public class Estudiante : Persona
    {
        // Atributo calculado
        public int EdadCalculada
        {
            get
            {
                return DateTime.Now.Year - AñoNacimiento;
            }
        }
    }
}
