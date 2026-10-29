using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using Unidad5_Capas.DAL;

namespace Unidad5_Capas.BLL
{
    public class ListaProducto
    {
        private List<Producto> productos;

        public ListaProducto()
        {
            productos = new List<Producto>
            {
                new Producto { Nombre = "Camisa", Precio = 100},
                new Producto { Nombre = "Pantalón", Precio = 250},
                new Producto { Nombre = "Zapatos", Precio = 300}
            };
        }

        public List<Producto> MostrarProducto()
        {
            return productos;
        }
    }
}

