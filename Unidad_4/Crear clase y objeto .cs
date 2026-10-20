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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Crear y mostrar un producto de ejemplo
            Producto producto1 = new Producto();
            producto1.Nombre = "Laptop";
            producto1.Precio = 350000;
            producto1.MostrarInfo();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            // Crear y mostrar un producto de ejemplo
            Producto producto1 = new Producto();
            producto1.Nombre = "Laptop";
            producto1.Precio = 350000;
            producto1.MostrarInfo();
        }
    }
}
