using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_3
{
    public partial class Integracion_completa : Form
    {
        public Integracion_completa()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int numero;

            // Validar que el usuario ingrese un número entero
            if (!int.TryParse(txtnumero.Text, out numero))
            {
                MessageBox.Show(
                    "Error: debe ingresar un número entero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Validar que el número esté entre 1 y 4
            if (numero < 1 || numero > 4)
            {
                MessageBox.Show(
                    "Error: el número debe estar entre 1 y 4.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Mostrar un mensaje según el número ingresado
            switch (numero)
            {
                case 1:
                    MessageBox.Show("Seleccionaste la opción 1.");
                    break;

                case 2:
                    MessageBox.Show("Seleccionaste la opción 2.");
                    break;

                case 3:
                    MessageBox.Show("Seleccionaste la opción 3.");
                    break;

                case 4:
                    MessageBox.Show("Seleccionaste la opción 4.");
                    break;

                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }
        }
    }
}
