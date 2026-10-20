using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4
{
    public class Tarea_Programada
    {
        public class Estudiante
        {
            // Propiedades de la clase
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Curso { get; set; }

            // Constructor
            public Estudiante(string nombre, int edad, string curso)
            {
                Nombre = nombre;
                Edad = edad;
                Curso = curso;
            }

            // Método para mostrar los datos
            public void MostrarDatos()
            {
                MessageBox.Show(
                    "Nombre: " + Nombre +
                    "\nEdad: " + Edad +
                    "\nCurso: " + Curso,
                    "Información del estudiante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
}
}
