using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public class Producto
    {
        private string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;
        public string Nombre
        {
            get { return  nombre; }
            set {  nombre = value; }
        }
        private double precio;
        public double Precio
        {
            get { return  precio; }
            set {  precio = value; }
        }
        public double ObtenerPrecioConIVA()
        {
            return precio * 1.13;
        }
    }
}
