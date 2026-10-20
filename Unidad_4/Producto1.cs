using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4
{
    class Producto
    {
        public string Nombre;
        public double Precio;

        public void MostrarInfo()
        {
            MessageBox.Show(
                "Nombre: " + Nombre +
                "\nPrecio: ₡" + Precio
            );
        }
    }

}
