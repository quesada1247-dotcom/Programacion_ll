using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_2
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class CompararyEvaluar : Form
    {
        public CompararyEvaluar()
        {
            InitializeComponent();
        }

        private void btncompararyevaluar_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            // Validar que los dos valores sean números
            if (!double.TryParse(this.textBox1.Text, out numero1) ||
                !double.TryParse(this.textBox2.Text, out numero2))
            {
                MessageBox.Show(
                    "Por favor, ingrese dos números válidos.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Realizar las operaciones matemáticas
            string resultado = "OPERACIONES MATEMÁTICAS\n\n";

            resultado += "Suma: " + (numero1 + numero2) + "\n";
            resultado += "Resta: " + (numero1 - numero2) + "\n";
            resultado += "Multiplicación: " + (numero1 * numero2) + "\n";

            if (numero2 != 0)
            {
                resultado += "División: " + (numero1 / numero2) + "\n";
                resultado += "Módulo: " + (numero1 % numero2) + "\n";
            }
            else
            {
                resultado += "División: No se puede dividir entre cero.\n";
                resultado += "Módulo: No se puede calcular entre cero.\n";
            }

            // Realizar las comparaciones
            resultado += "\nCOMPARACIONES\n\n";

            resultado += numero1 + " > " + numero2 + ": "
                + (numero1 > numero2) + "\n";

            resultado += numero1 + " < " + numero2 + ": "
                + (numero1 < numero2) + "\n";

            resultado += numero1 + " == " + numero2 + ": "
                + (numero1 == numero2) + "\n";

            resultado += numero1 + " >= " + numero2 + ": "
                + (numero1 >= numero2) + "\n";

            resultado += numero1 + " <= " + numero2 + ": "
                + (numero1 <= numero2) + "\n";

            // Mostrar los resultados en un MessageBox (no hay lblResultado en el diseñador)
            MessageBox.Show(resultado, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncolordeformulario_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
    }

        private void btncolortextbox_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.BackColor = colorDialog1.Color;
                this.textBox2.BackColor = colorDialog1.Color;
            }
        }

        private void btncolorlabel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.BackColor = colorDialog1.Color;
                this.textBox2.BackColor = colorDialog1.Color;
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
