using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examen_Parcial_2.Ejercisio_1
{
    public partial class Gestión_de_empleados : Form
    {
        List<Empleado> empleados = new List<Empleado>();

        public Gestión_de_empleados()
        {
            InitializeComponent();
            
            // Configurar las columnas del DataGridView
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add("colIdentificacion", "Identificación");
            dgvEmpleados.Columns.Add("colNombre", "Nombre");
            dgvEmpleados.Columns.Add("colSalario", "Salario");
            dgvEmpleados.Columns.Add("colSalarioAnual", "Salario anual");

            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (txtIdentificacion.Text == "" ||
                txtNombre.Text == "" ||
                txtSalario.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            decimal salario;

            if (!decimal.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                MessageBox.Show("Ingrese un salario válido.");
                return;
            }

            // Crear el objeto empleado
            Empleado nuevoEmpleado = new Empleado();

            nuevoEmpleado.Identificacion = txtIdentificacion.Text;
            nuevoEmpleado.Nombre = txtNombre.Text;
            nuevoEmpleado.Salario = salario;

            // Agregar empleado a la lista
            empleados.Add(nuevoEmpleado);

            MessageBox.Show("Empleado agregado correctamente.");

            // Limpiar los campos
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();

            foreach (Empleado empleado in empleados)
            {
                dgvEmpleados.Rows.Add(
                    empleado.Identificacion,
                    empleado.Nombre,
                    empleado.Salario,
                    empleado.SalarioAnual
                );
            }
        }
    }
}
