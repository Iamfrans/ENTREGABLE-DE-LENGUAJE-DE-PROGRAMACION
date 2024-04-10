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
    public partial class frmSalidasInventario : Form
    {
        SqlConnection con = new SqlConnection("TuCadenaDeConexion"); // Replace with your connection string

        public frmSalidasInventario()
        {
            InitializeComponent();
        }

        private void frmSalidasInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarSalidaInventario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void CargarProductos()
        {
            string query = "SELECT * FROM Productos"; // Assuming a "Productos" table exists
            SqlCommand cmd = new SqlCommand(query, con);

            try // Wrap database operations in a try-catch block for error handling
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbProducto.Items.Add(new ComboboxItem { Text = reader["Nombre"].ToString(), Value = reader["Id"].ToString() });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void GuardarSalidaInventario()
        {
            if (cmbProducto.SelectedIndex == -1 || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
                return;
            }

            string query = "INSERT INTO SalidasInventario (ProductoId, Cantidad, Fecha) VALUES (@productoId, @cantidad, @fecha)";
            SqlCommand cmd = new SqlCommand(query, con);

            try // Wrap database operations in a try-catch block for error handling
            {
                cmd.Parameters.AddWithValue("@productoId", int.Parse((cmbProducto.SelectedItem as ComboboxItem).Value));
                cmd.Parameters.AddWithValue("@cantidad", int.Parse(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@fecha", dateTimePickerFecha.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salida de inventario guardada correctamente");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando salida de inventario: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Text = "";
            dateTimePickerFecha.Value = DateTime.Now;
        }
    }

    public class ComboboxItem // Optional class for storing product information
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
