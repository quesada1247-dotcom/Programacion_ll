using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_5
{
    internal class ProductoBLL
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            lista.Add(new Producto
            {
                Nombre = "Laptop",
                Precio = 350000
            });

            lista.Add(new Producto
            {
                Nombre = "Mouse",
                Precio = 8500
            });

            lista.Add(new Producto
            {
                Nombre = "Teclado",
                Precio = 15000
            });

            lista.Add(new Producto
            {
                Nombre = "Monitor",
                Precio = 95000
            });

            return lista;
        }
    }
}
