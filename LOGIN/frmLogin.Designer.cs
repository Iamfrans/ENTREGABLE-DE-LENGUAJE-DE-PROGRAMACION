namespace LOGIN
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBxShowPas = new System.Windows.Forms.CheckBox();
            this.textComPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(70, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Atras para iniciar Sesión";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ya tienes una cuenta?\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(38, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBxShowPas
            // 
            this.checkBxShowPas.AutoSize = true;
            this.checkBxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBxShowPas.Location = new System.Drawing.Point(115, 270);
            this.checkBxShowPas.Name = "checkBxShowPas";
            this.checkBxShowPas.Size = new System.Drawing.Size(143, 21);
            this.checkBxShowPas.TabIndex = 19;
            this.checkBxShowPas.Text = "Mostrar contraseña";
            this.checkBxShowPas.UseVisualStyleBackColor = true;
            this.checkBxShowPas.CheckedChanged += new System.EventHandler(this.checkBxShowPas_CheckedChanged);
            // 
            // textComPassword
            // 
            this.textComPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textComPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textComPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComPassword.Location = new System.Drawing.Point(39, 236);
            this.textComPassword.Multiline = true;
            this.textComPassword.Name = "textComPassword";
            this.textComPassword.PasswordChar = '•';
            this.textComPassword.Size = new System.Drawing.Size(216, 28);
            this.textComPassword.TabIndex = 18;
            this.textComPassword.TextChanged += new System.EventHandler(this.textComPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirmar contraseña";
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.Location = new System.Drawing.Point(39, 163);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '•';
            this.textpassword.Size = new System.Drawing.Size(216, 28);
            this.textpassword.TabIndex = 16;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contraseña";
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(39, 88);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(216, 28);
            this.textUsername.TabIndex = 14;
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Creando Cuenta";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBxShowPas);
            this.Controls.Add(this.textComPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBxShowPas;
        private System.Windows.Forms.TextBox textComPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}