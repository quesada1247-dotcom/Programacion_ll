using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial_2
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
           //Application.Run(new Ejercisio_1.Gestión_de_empleados());
           //Application.Run(new Ejercisio_2.Registro_de_actividades());
           Application.Run(new Ejercisio_4.Administración_de_productos());
        }
    }
}
