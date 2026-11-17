using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBD
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
            //Application.Run(new FrmConexion());
            //Application.Run(new FrmInsertar());
            //Application.Run(new FrmBuscar());
            //Application.Run(new FrmEliminar());
            Application.Run(new FrmPrincipal());
        }
    }
}
