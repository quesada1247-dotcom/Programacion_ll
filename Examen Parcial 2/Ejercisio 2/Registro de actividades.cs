using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial_2.Ejercisio_2
{
    public partial class Registro_de_actividades : Form
    {
        List<Actividad> actividades = new List<Actividad>();

        public Registro_de_actividades()
        {
            InitializeComponent();

            // Crear las columnas
            dgvActividades.Columns.Clear();

            dgvActividades.Columns.Add("colDescripcion", "Descripción");
            dgvActividades.Columns.Add("colResponsable", "Responsable");
            dgvActividades.Columns.Add("colFecha", "Fecha");
            dgvActividades.Columns.Add("colInformacion", "Información");

            // Configurar DataGridView
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.ReadOnly = true;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar al tamaño del formulario
            dgvActividades.Anchor = AnchorStyles.Top |
                                    AnchorStyles.Bottom |
                                    AnchorStyles.Left |
                                    AnchorStyles.Right;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "" ||
        txtResponsable.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            // Crear una nueva actividad
            Actividad nuevaActividad = new Actividad();

            nuevaActividad.Descripcion = txtDescripcion.Text;
            nuevaActividad.Responsable = txtResponsable.Text;

            // Asignar fecha actual
            nuevaActividad.Fecha = DateTime.Now;

            // Guardar en la lista
            actividades.Add(nuevaActividad);

            MessageBox.Show("Actividad registrada correctamente.");

            // Limpiar los campos
            txtDescripcion.Clear();
            txtResponsable.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dgvActividades.Rows.Clear();

            // Recorrer la lista utilizando foreach
            foreach (Actividad actividad in actividades)
            {
                dgvActividades.Rows.Add(
                    actividad.Descripcion,
                    actividad.Responsable,
                    actividad.Fecha.ToString("dd/MM/yyyy"),
                    actividad.Informacion
                );
            }
        }
    }
}
