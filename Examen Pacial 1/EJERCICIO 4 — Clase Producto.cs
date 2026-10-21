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
    public partial class EJERCICIO_4___Clase_Producto : Form
    {
        public EJERCICIO_4___Clase_Producto()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valido = true;
            double precio;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ingrese el código");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese el nombre");
                valido = false;
            }

            if (!double.TryParse(textBox3.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(textBox3, "Ingrese un precio mayor que cero");
                valido = false;
            }

            if (!valido)
            {
                MessageBox.Show("Corrija los campos indicados.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            producto producto = new producto();

            producto.Codigo = textBox1.Text.Trim();
            producto.Nombre = textBox2.Text.Trim();
            producto.Precio = precio;

            double precioConIVA = producto.ObtenerPrecioConIVA();

            MessageBox.Show(
                "Código: " + producto.Codigo +
                "\nNombre: " + producto.Nombre +
                "\nPrecio sin IVA: " + producto.Precio.ToString("C2") +
                "\nPrecio con IVA (13%): " + precioConIVA.ToString("C2"),
                "Datos del producto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            errorProvider1.Clear();

            textBox1.Focus();
        }
    }
}
