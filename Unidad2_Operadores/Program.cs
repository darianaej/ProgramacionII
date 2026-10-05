using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad2_Operadores.Ejemplos_Operadores;

namespace Unidad2_Operadores
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Tarea_Unidad2_CSharp());
            //Application.Run(new EjemplosOperadores());
            //Application.Run(new EjemploOperadores());
            //Application.Run(new Comparadores());
            //Application.Run(new EjemplosControles());
            Application.Run(new Colores());
        }
    }
}
