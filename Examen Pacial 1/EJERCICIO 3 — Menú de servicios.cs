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
    public partial class EJERCICIO_3___Menú_de_servicios : Form
    {
        public EJERCICIO_3___Menú_de_servicios()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (cmbservicio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un servicio.");
                return;
            }

            double precio = 0;

            switch (cmbservicio.SelectedIndex)
            {
                case 0:
                    precio = 15000;
                    break;

                case 1:
                    precio = 20000;
                    break;

                case 2:
                    precio = 10000;
                    break;
            }

            MessageBox.Show(
                "Servicio: " + cmbservicio.SelectedItem.ToString() +
                "\nPrecio: " + precio.ToString("C0"),
                "Resultado"
            );
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbservicio.SelectedIndex = -1;
            cmbservicio.Text = "";

            cmbservicio.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
