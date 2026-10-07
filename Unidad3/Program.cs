using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad3.Tarea_Programada_3;
using Unidad3_MessageBox;

namespace Unidad3
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
            //Application.Run(new Ejercicio1_Selector());
            //Application.Run(new Ejercicio2_Confirmacióndeacción());
            //Application.Run(new Ejercicio3_IntegraciónCompleta());
            Application.Run(new Tarea());
        }
    }
}
