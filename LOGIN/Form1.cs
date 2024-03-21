using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            // Nombre de usuario ingresado por el usuario
            string username = textUsername.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            // Contraseña ingresada por el usuario
            string password = textpassword.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Este espacio es para redirigir a la ventana de creación de cuenta en el formulario "frmLogin.cs"
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide(); // Oculta el formulario actual mientras se abre el formulario de inicio de sesión
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Este espacio es para ingresar al menú principal después de iniciar sesión
            // Aquí deberías implementar la lógica de autenticación y redireccionar al menú principal si la autenticación es exitosa.
        }

        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            // Esto es para mostrar u ocultar la contraseña según el estado de la casilla de verificación
            if (checkBxShowPas.Checked)
            {
                textpassword.UseSystemPasswordChar = false; // Muestra la contraseña
            }
            else
            {
                textpassword.UseSystemPasswordChar = true; // Oculta la contraseña
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Este espacio es para ingresar a la página sin necesidad de iniciar sesión ni crear una cuenta
            // Aquí deberías implementar la lógica para permitir el acceso a la página sin autenticación.
        }
    }
}
