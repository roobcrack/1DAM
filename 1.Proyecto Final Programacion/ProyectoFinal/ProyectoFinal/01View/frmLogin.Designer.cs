namespace ProyectoFinal._01View
{
    partial class frmLogin
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
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            txtError = new Label();
            lblCrearUsuario = new LinkLabel();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(151, 190);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(137, 55);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 123);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(183, 120);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtError
            // 
            txtError.AutoSize = true;
            txtError.ForeColor = Color.Red;
            txtError.Location = new Point(151, 163);
            txtError.Name = "txtError";
            txtError.Size = new Size(58, 15);
            txtError.TabIndex = 6;
            txtError.Text = "                 ";
            // 
            // lblCrearUsuario
            // 
            lblCrearUsuario.AutoSize = true;
            lblCrearUsuario.Location = new Point(183, 257);
            lblCrearUsuario.Name = "lblCrearUsuario";
            lblCrearUsuario.Size = new Size(78, 15);
            lblCrearUsuario.TabIndex = 7;
            lblCrearUsuario.TabStop = true;
            lblCrearUsuario.Text = "Crear Usuario";
            lblCrearUsuario.LinkClicked += lblCrearUsuario_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 324);
            Controls.Add(lblCrearUsuario);
            Controls.Add(txtError);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label label1;
        private Label label2;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Label txtError;
        private LinkLabel lblCrearUsuario;
    }
}