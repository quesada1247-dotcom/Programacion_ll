using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5.Ejercisio3
{
    public partial class GestionProductos : Form
    {
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ProductoBLL negocio = new ProductoBLL();

            List<Producto> lista = negocio.ObtenerProductos();

            string informacion = "";

            foreach (Producto producto in lista)
            {
                informacion += "Nombre: " + producto.Nombre +
                               "\nPrecio: ₡" + producto.Precio +
                               "\n-------------------\n";
            }

            MessageBox.Show(informacion, "Lista de productos");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
       "¿Desea guardar los cambios?",
       "Confirmar guardado",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Los cambios se guardaron correctamente.");
            }
            else
            {
                MessageBox.Show("No se guardaron los cambios.");
            }
        }
    }s
}
