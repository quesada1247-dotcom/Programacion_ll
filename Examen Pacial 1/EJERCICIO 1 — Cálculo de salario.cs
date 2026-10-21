using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Pacial_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            double horas;
            double pagoHora;

            // Validar el nombre
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del trabajador");
                txtNombre.Focus();
                return;
            }

            // Validar las horas
            if (!double.TryParse(txtHoras.Text, out horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese horas mayores que cero");
                txtHoras.Focus();
                return;
            }

            // Validar el pago por hora
            if (!double.TryParse(txtPago.Text, out pagoHora) || pagoHora <= 0)
            {
                MessageBox.Show("Ingrese un pago por hora mayor que cero");
                txtPago.Focus();
                return;
            }

            double salario;

            // Calcular el salario
            if (horas <= 40)
            {
                salario = horas * pagoHora;
            }
            else
            {
                double horasExtra = horas - 40;

                salario = (40 * pagoHora) +
                          (horasExtra * pagoHora * 1.5);
            }

            // Mostrar el resultado
            txtresultado.Text = "Salario de " + nombre +
                                ": ¢" + salario.ToString("N2");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtPago.Clear();

            txtresultado.Text = "Resultado:";

            txtNombre.Focus();
        }
    }
}
