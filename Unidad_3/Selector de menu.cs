using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_3
{
    public partial class Selector_de_menu : Form
    {
        public Selector_de_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (txtopcion.Text)
            {
                case "1":
                    MessageBox.Show("Seleccionaste la opción 1");
                    break;

                case "2":
                    MessageBox.Show("Seleccionaste la opción 2");
                    break;

                case "3":
                    MessageBox.Show("Seleccionaste la opción 3");
                    break;

                default:
                    MessageBox.Show("Por favor, ingrese una opción válida: 1, 2 o 3");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
