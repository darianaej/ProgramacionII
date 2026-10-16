using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4_POO.Practicas
{
    public class Producto
    {
        //Atributo
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int precio;
        public int Precio
        {
            get { return precio; }
            set { precio = value; }

        }

        //Metodo
        public void MostrarInformacion()
        {
            MessageBox.Show("Nombre:" + Nombre + "\nPrecio:" + Precio);

        }

    }
}
