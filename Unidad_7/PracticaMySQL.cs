using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_7.Conexion;
using MySql.Data.MySqlClient;

namespace Unidad_7
{
    public partial class PracticaMySQL : Form
    {
        public PracticaMySQL()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    MessageBox.Show(
                        "¡Conexión exitosa con MySQL!",
                        "Conexión correcta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al conectar con MySQL: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(
                    "Debe completar todos los campos.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Clientes (Nombre, Correo) VALUES (@Nombre, @Correo)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        comando.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Cliente registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtNombre.Clear();
                txtCorreo.Clear();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "SELECT Correo FROM Clientes WHERE Nombre = @Nombre LIMIT 1";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre", txtBuscarNombre.Text.Trim());

                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            txtCorreoModificar.Text = resultado.ToString();

                            MessageBox.Show(
                                "Cliente encontrado correctamente.",
                                "Búsqueda exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            txtCorreoModificar.Clear();

                            MessageBox.Show("No se encontró ningún cliente con ese nombre.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
            {
                MessageBox.Show("Primero debe buscar un cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoModificar.Text))
            {
                MessageBox.Show("Ingrese el nuevo correo.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"UPDATE Clientes
                                SET Correo = @Correo
                                WHERE Nombre = @Nombre
                                LIMIT 1";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@Correo", txtCorreoModificar.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Nombre", txtBuscarNombre.Text.Trim());

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "Correo actualizado correctamente.",
                                "Modificación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente para modificar.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un nombre
            if (string.IsNullOrWhiteSpace(txtNombreEliminar.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del cliente que desea eliminar.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Solicitar confirmación antes de eliminar
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si selecciona NO, cancelar la operación
            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"DELETE FROM Clientes
                                WHERE Nombre = @Nombre
                                LIMIT 1";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            txtNombreEliminar.Text.Trim()
                        );

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "Cliente eliminado correctamente.",
                                "Eliminación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            txtNombreEliminar.Clear();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontró ningún cliente con ese nombre.",
                                "Cliente no encontrado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
