namespace entregable
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            textBox1 = new TextBox();
            txtPassword = new Label();
            textBox2 = new TextBox();
            txtComPassword = new Label();
            checkBxShowPas = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(248, 34);
            label2.TabIndex = 1;
            label2.Text = "Crea tu Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 134);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(32, 160);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += this.txtUsername_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(32, 234);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '•';
            textBox1.Size = new Size(216, 28);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Location = new Point(32, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(99, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(37, 309);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(216, 28);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // txtComPassword
            // 
            txtComPassword.AutoSize = true;
            txtComPassword.Location = new Point(37, 283);
            txtComPassword.Name = "txtComPassword";
            txtComPassword.Size = new Size(186, 23);
            txtComPassword.TabIndex = 6;
            txtComPassword.Text = "Confirmar Contraseña";
            // 
            // checkBxShowPas
            // 
            checkBxShowPas.AutoSize = true;
            checkBxShowPas.Cursor = Cursors.Hand;
            checkBxShowPas.FlatStyle = FlatStyle.Flat;
            checkBxShowPas.Location = new Point(71, 355);
            checkBxShowPas.Name = "checkBxShowPas";
            checkBxShowPas.Size = new Size(182, 27);
            checkBxShowPas.TabIndex = 8;
            checkBxShowPas.Text = "Mostrar contraseña";
            checkBxShowPas.UseVisualStyleBackColor = true;
            checkBxShowPas.CheckedChanged += this.checkBxShowPas_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 399);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 9;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 455);
            label4.Name = "label4";
            label4.Size = new Size(178, 23);
            label4.TabIndex = 10;
            label4.Text = "Ya tienes una cuenta?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(48, 492);
            label5.Name = "label5";
            label5.Size = new Size(200, 23);
            label5.TabIndex = 11;
            label5.Text = "Atrás para Iniciar sesión";
            label5.Click += label5_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 566);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBxShowPas);
            Controls.Add(textBox2);
            Controls.Add(txtComPassword);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox textBox1;
        private Label txtPassword;
        private TextBox textBox2;
        private Label txtComPassword;
        private CheckBox checkBxShowPas;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
