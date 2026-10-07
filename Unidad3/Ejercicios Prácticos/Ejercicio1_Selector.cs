using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad3
{
    public partial class Ejercicio1_Selector : Form
    {
        public Ejercicio1_Selector()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            int opcion = Convert.ToInt32(txtOpcion.Text);
            switch (opcion)
            {
                case 1: MessageBox.Show("Seleccionaste la opción 1");break;
                   
                case 2: MessageBox.Show("Seleccionaste la opción 2");break;
                    
                case 3: MessageBox.Show("Seleccionaste la opción 3");break;

                default : MessageBox.Show("Opción no válida");break;
            }


        }
    }
}
