using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5.Ejercisio2
{
    public partial class RegistroEstudiantes : Form
    {
        public RegistroEstudiantes()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int anio;

            if (int.TryParse(txtAnio.Text, out anio))
            {
                if (anio > 0 && anio <= DateTime.Now.Year)
                {
                    Estudiante estudiante = new Estudiante();

                    estudiante.AñoNacimiento = anio;

                    MessageBox.Show(
                        "Información del estudiante\n\n" +
                        "Año de nacimiento: " + estudiante.AñoNacimiento +
                        "\nEdad calculada: " + estudiante.EdadCalculada,
                        "Datos del estudiante"
                    );
                }
                else
                {
                    MessageBox.Show("Ingrese un año de nacimiento válido.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un año válido.");
            }
        }
    }
}
