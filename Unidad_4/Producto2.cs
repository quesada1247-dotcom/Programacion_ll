using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_4
{
    internal class Producto2
    {
        class Producto
        {
            private string nombre;
            private double precio;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public double Precio
            {
                get { return precio; }
                set { precio = value; }
            }

            public void MostrarInfo()
            {
                System.Windows.Forms.MessageBox.Show(
                    "Nombre: " + Nombre +
                    "\nPrecio: ₡" + Precio
                );
            }
        }
    }
}
