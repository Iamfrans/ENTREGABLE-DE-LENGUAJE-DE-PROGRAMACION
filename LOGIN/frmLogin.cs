using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB:$:=;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();  
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textComPassword_TextChanged(object sender, EventArgs e)
        {
            //En este espacio va la confirmacion de contraseña
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "" && textpassword.Text == "" && textComPassword.Text == "")
            {
                MessageBox.Show("Username ans Password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textpassword.Text == textComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES"(+)
            }
        }

        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            //este espacio es para mostrar la contraseña
            if (checkBxShowPas.Checked)
            {
                textpassword.PasswordChar = '\0';
                textComPassword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '•';
                textComPassword.PasswordChar = '•';
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            //en este espacio va el nombre de usuario
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {
            //en este espacio va la contraseña que se quiere crear 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //este espacio es para ir al formulario Form1.cs
        }
    }
}
