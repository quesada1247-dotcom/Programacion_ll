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
    public partial class EJERCICIO_2___Clasificación_de_una_nota : Form
    {
        public EJERCICIO_2___Clasificación_de_una_nota()
        {
            InitializeComponent();

        }

        private string ClasificarNota(double nota)
        {
            if (nota >= 90)
            {
                return "Excelente";
            }
            else if (nota >= 80)
            {
                return "Muy bueno";
            }
            else if (nota >= 70)
            {
                return "Bueno";
            }
            else if (nota >= 60)
            {
                return "Regular";
            }
            else
            {
                return "Deficiente";
            }
        }
        private void EJERCICIO_2___Clasificación_de_una_nota_Load(object sender, EventArgs e)
        {

        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            double nota;

            if (!double.TryParse(txtNota.Text, out nota))
            {
                MessageBox.Show("Ingrese una nota válida.");
                txtNota.Focus();
                return;
            }

            if (nota < 0 || nota > 100)
            {
                MessageBox.Show("La nota debe estar entre 0 y 100.");
                txtNota.Focus();
                return;
            }

            string resultado = ClasificarNota(nota);

            txtresultado.Text = "Resultado: " + resultado;

            if (nota >= 90)
            {
                txtresultado.BackColor = Color.LightGreen;
            }
            else if (nota < 60)
            {
                txtresultado.BackColor = Color.LightCoral;
            }
            else
            {
                txtresultado.BackColor = SystemColors.Control;
            }

            if (!lstCategorias.Items.Contains(resultado))
            {
                lstCategorias.Items.Add(resultado);
            }

            lstCategorias.SelectedItem = resultado;
        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCategorias.Items.Clear();

            lstCategorias.Items.Add("Excelente");
            lstCategorias.Items.Add("Muy bueno");
            lstCategorias.Items.Add("Bueno");
            lstCategorias.Items.Add("Regular");
            lstCategorias.Items.Add("Deficiente");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtNota.Clear();

            txtresultado.Text = "Resultado";
            txtresultado.BackColor = SystemColors.Control;

            lstCategorias.ClearSelected();

            txtNota.Focus();
        }
    }
}
