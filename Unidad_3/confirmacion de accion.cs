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
    public partial class txtconfirmaciondeunaaccion : Form
    {
        public txtconfirmaciondeunaaccion()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Desea salir del programa?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
        );
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }    
    }  
}
