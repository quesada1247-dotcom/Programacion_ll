using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_1
{
    public partial class Multiplicacion : Form
    {
        public Multiplicacion()
        {
            InitializeComponent();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double numero1;
    double numero2;
    double resultado;

            // Usar los TextBox definidos en el diseñador (textBox1, textBox2)
            if (double.TryParse(this.textBox1.Text, out numero1) &&
                double.TryParse(this.textBox2.Text, out numero2))
            {
                resultado = numero1 * numero2;

                // Mostrar el resultado en un MessageBox (lblResultado no existe en el diseñador)
                MessageBox.Show("Resultado: " + resultado.ToString());
            }
            else
            {
                MessageBox.Show("Por favor, ingrese dos números decimales válidos.");
            }
        }
    }
}
