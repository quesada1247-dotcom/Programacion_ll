using Examen_Parcial_2.Ejercicio_4;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial_2.Ejercisio_4
{
    public partial class Administración_de_productos : Form
    {
        public Administración_de_productos()
        {

            InitializeComponent();

            // Crear columnas del DataGridView
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add("colCodigo", "Código");
            dgvProductos.Columns.Add("colNombre", "Nombre");
            dgvProductos.Columns.Add("colPrecio", "Precio");
            dgvProductos.Columns.Add("colCantidad", "Cantidad");
            dgvProductos.Columns.Add("colCategoria", "Categoría");

            // Configurar DataGridView
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar al tamaño del formulario
            dgvProductos.Anchor = AnchorStyles.Top |
                                  AnchorStyles.Bottom |
                                  AnchorStyles.Left |
                                  AnchorStyles.Right;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
        txtPrecio.Text.Trim() == "" ||
        txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            decimal precio;
            int cantidad;

            if (!decimal.TryParse(txtPrecio.Text, NumberStyles.Number,
                CultureInfo.CurrentCulture, out precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Producto
                (Nombre, Precio, Cantidad, Categoria)
                VALUES (@nombre, @precio, @cantidad, @categoria)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.Parameters.AddWithValue("@categoria", 1);

                        comando.ExecuteNonQuery();

                        txtCodigo.Text = comando.LastInsertedId.ToString();
                    }
                }

                MessageBox.Show("Producto agregado correctamente.");

                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Clear();

                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                SELECT P.Codigo, P.Nombre, P.Precio,
                       P.Cantidad, C.Nombre AS Categoria
                FROM Producto P
                INNER JOIN Categoria C
                ON P.Categoria = C.Codigo";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            dgvProductos.Rows.Add(
                                lector["Codigo"],
                                lector["Nombre"],
                                lector["Precio"],
                                lector["Cantidad"],
                                lector["Categoria"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo;

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Ingrese un código válido.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = Conexion.ObtenerConexion())
                    {
                        conexion.Open();

                        string consulta =
                            "DELETE FROM Producto WHERE Codigo = @codigo";

                        using (MySqlCommand comando =
                            new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@codigo", codigo);

                            int filas = comando.ExecuteNonQuery();

                            if (filas > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.");
                                txtCodigo.Clear();
                                CargarProductos();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el producto.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
        private void CargarProductos()
        {
            try
            {
                dgvProductos.Rows.Clear();

                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "SELECT Codigo, Nombre, Precio, Cantidad, Categoria FROM Producto";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            dgvProductos.Rows.Add(
                                lector["Codigo"],
                                lector["Nombre"],
                                lector["Precio"],
                                lector["Cantidad"],
                                lector["Categoria"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
    }
}
