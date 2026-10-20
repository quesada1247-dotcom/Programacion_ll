using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4
{
    public partial class Uso_de_propiedades_get_set : Form
    {
        public Uso_de_propiedades_get_set()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Validar que el nombre no este vacio
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre del producto.");
                txtNombre.Focus();
                return;
            }

            // Validar que el precio sea un numero mayor que cero
            double precio;

            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Debe ingresar un precio mayor que cero.");
                txtPrecio.Focus();
                return;
            }

            // Crear el objeto
            Producto producto1 = new Producto();

            // Asignar los datos usando las propiedades
            producto1.Nombre = txtNombre.Text.Trim();
            producto1.Precio = precio;

            // Mostrar la informacion
            producto1.MostrarInfo();
        }
    }
}
