using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Unidad_4.Tarea_Programada;

namespace Unidad_4
{
    public partial class Tarea_Programada_4 : Form
    {
        public Tarea_Programada_4()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Limpiar errores anteriores
            errorProvider1.Clear();

            bool datosCorrectos = true;

            // Validar el nombre
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(
                    textBox1, "Debe ingresar el nombre");
                datosCorrectos = false;
            }

            // Validar la edad
            int edad;

            if (!int.TryParse(textBox2.Text, out edad) || edad <= 0)
            {
                errorProvider1.SetError(
                    textBox2, "Ingrese una edad mayor que 0");
                datosCorrectos = false;
            }

            // Validar el curso
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.SetError(
                    textBox3, "Debe ingresar el curso");
                datosCorrectos = false;
            }

            // Si hay algún error, no continuar
            if (!datosCorrectos)
            {
                MessageBox.Show(
                    "Por favor, corrija los datos indicados.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Crear el objeto Estudiante
            Estudiante estudiante = new Estudiante(
                textBox1.Text.Trim(),
                edad,
                textBox3.Text.Trim()
            );

            // Mostrar los datos del estudiante
            estudiante.MostrarDatos();
        }
    }
}
