using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add reference to ADO.NET

namespace entregable
{
    public partial class frmProductos : Form // Inherit from Form class
    {
        SqlConnection con = new SqlConnection("TuCadenaDeConexion"); // Replace with your connection string

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void CargarCategorias()
        {
            string query = "SELECT * FROM Categorias"; // Assuming a "Categorias" table exists
            SqlCommand cmd = new SqlCommand(query, con);

            try // Wrap database operations in a try-catch block for error handling
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCategoria.Items.Add(new ComboboxItem { Text = reader["Nombre"].ToString(), Value = reader["Id"].ToString() });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void GuardarProducto()
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            string query = "INSERT INTO Productos (Nombre, Precio, Cantidad, Descripcion, CategoriaId) VALUES (@nombre, @precio, @cantidad, @descripcion, @categoriaId)";
            SqlCommand cmd = new SqlCommand(query, con);

            try // Wrap database operations in a try-catch block for error handling
            {
                cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@cantidad", int.Parse(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@categoriaId", int.Parse((cmbCategoria.SelectedItem as ComboboxItem).Value));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Producto guardado correctamente");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando producto: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreProducto.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }
    }

    public class ComboboxItem // Optional class for storing category information
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
