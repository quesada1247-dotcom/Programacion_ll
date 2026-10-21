using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Pacial_1
{
    public class producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public double ObtenerPrecioConIVA()
        {
            return Precio * 1.13;
        }
    }
}
