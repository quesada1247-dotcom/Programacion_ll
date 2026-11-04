using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_5
{
    public partial class interfaz : Form
    {
        public interfaz()
        {
            InitializeComponent();
        }

        private void interfaz_Load(object sender, EventArgs e)
        {
            ProductoBLL negocio = new ProductoBLL();

            dgvProductos.DataSource = negocio.ObtenerProductos();
        }
    }
}
