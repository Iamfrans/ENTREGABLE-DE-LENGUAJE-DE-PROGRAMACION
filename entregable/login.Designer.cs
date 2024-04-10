namespace entregable
{
    partial class login
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
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            checkBxShowPas = new CheckBox();
            textBox1 = new TextBox();
            txtPassword = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(78, 402);
            label5.Name = "label5";
            label5.Size = new Size(145, 23);
            label5.TabIndex = 23;
            label5.Text = "Crear una cuenta";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 366);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 22;
            label4.Text = "No tengo una cuenta";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(47, 310);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 21;
            button1.Text = "INICIAR SESIÓN";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBxShowPas
            // 
            checkBxShowPas.AutoSize = true;
            checkBxShowPas.Cursor = Cursors.Hand;
            checkBxShowPas.FlatStyle = FlatStyle.Flat;
            checkBxShowPas.Location = new Point(117, 246);
            checkBxShowPas.Name = "checkBxShowPas";
            checkBxShowPas.Size = new Size(182, 27);
            checkBxShowPas.TabIndex = 20;
            checkBxShowPas.Text = "Mostrar contraseña";
            checkBxShowPas.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 195);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '•';
            textBox1.Size = new Size(216, 28);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Location = new Point(47, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(99, 23);
            txtPassword.TabIndex = 16;
            txtPassword.Text = "Contraseña";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(47, 121);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 15;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 95);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 14;
            label3.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(35, 29);
            label2.Name = "label2";
            label2.Size = new Size(217, 34);
            label2.TabIndex = 13;
            label2.Text = "Iniciar Sesión";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 12;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(321, 484);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBxShowPas);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button button1;
        private CheckBox checkBxShowPas;
        private TextBox textBox1;
        private Label txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}