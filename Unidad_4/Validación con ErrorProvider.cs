using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4
{
    public partial class Validación_con_ErrorProvider : Form
    {
        public Validación_con_ErrorProvider()
        {
            InitializeComponent();
        }

        private void Validación_con_ErrorProvider_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Limpiar errores anteriores
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(textprecio, "");

            bool datosCorrectos = true;
            double precio = 0;

            // Validar el nombre
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                errorProvider1.SetError(
                    txtnombre,
                    "Debe ingresar el nombre del producto."
                );

                datosCorrectos = false;
            }

            // Validar el precio
            string textoPrecio = textprecio.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoPrecio))
            {
                errorProvider1.SetError(
                    textprecio,
                    "Debe ingresar el precio."
                );

                datosCorrectos = false;
            }
            else if (!double.TryParse(
                textoPrecio,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out precio) || precio <= 0)
            {
                errorProvider1.SetError(
                    textprecio,
                    "Ingrese un numero valido mayor que cero."
                );

                datosCorrectos = false;
            }

            // Detener el proceso si hay errores
            if (!datosCorrectos)
            {
                MessageBox.Show("Por favor, corrija los datos incorrectos.");
                return;
            }

            // Crear y guardar los datos en el objeto
            Producto producto1 = new Producto();

            producto1.Nombre = txtnombre.Text.Trim();
            producto1.Precio = precio;

            MessageBox.Show(
                "Producto guardado correctamente.\n\n" +
                "Nombre: " + producto1.Nombre +
                "\nPrecio: ₡" + producto1.Precio.ToString("N2")
            );
        }
    }
}
