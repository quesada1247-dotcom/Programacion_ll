using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_2.Ejercisio_1
{
    public class Empleado : Persona
    {
        public decimal Salario { get; set; }

        public decimal SalarioAnual
        {
            get { return Salario * 12; }
        }
    }
}
