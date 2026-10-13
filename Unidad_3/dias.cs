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
    public partial class dias : Form
    {
        public dias()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int dia;

            if (!int.TryParse(this.textBox1.Text, out dia))
            {
                MessageBox.Show("Por favor, ingrese un número entero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            switch (dia)
            {
                case 1:
                    MessageBox.Show("El día es Lunes");
                    break;

                case 2:
                    MessageBox.Show("El día es Martes");
                    break;

                case 3:
                    MessageBox.Show("El día es Miércoles");
                    break;

                case 4:
                    MessageBox.Show("El día es Jueves");
                    break;

                case 5:
                    MessageBox.Show("El día es Viernes");
                    break;

                case 6:
                    MessageBox.Show("El día es Sábado");
                    break;

                case 7:
                    MessageBox.Show("El día es Domingo");
                    break;

                default:
                    MessageBox.Show("Error: ingrese un número del 1 al 7.",
                                    "Número inválido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
