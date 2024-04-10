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
    public partial class frmProveedores : Form
    {
        SqlConnection con = new SqlConnection("TuCadenaDeConexion"); // Replace with your connection string

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // No initial data loading needed (assuming no dependent dropdowns)
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void GuardarProveedor()
        {
            if (string.IsNullOrEmpty(txtNombreProveedor.Text) || string.IsNullOrEmpty(txtContacto.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
                return;
            }

            string query = "INSERT INTO Proveedores (Nombre, Contacto, Telefono, Correo) VALUES (@nombre, @contacto, @telefono, @correo)";
            SqlCommand cmd = new SqlCommand(query, con);

            try // Wrap database operations in a try-catch block for error handling
            {
                cmd.Parameters.AddWithValue("@nombre", txtNombreProveedor.Text);
                cmd.Parameters.AddWithValue("@contacto", txtContacto.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Proveedor guardado correctamente");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando proveedor: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreProveedor.Text = "";
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }
    }
}
