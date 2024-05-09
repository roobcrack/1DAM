namespace ProyectoFinal._01View
{
    partial class frmRegistro
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
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRepetirContraseña = new TextBox();
            btnRegistrarse = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(162, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(162, 108);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 73);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 148);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 4;
            label3.Text = "Repetir contraseña";
            // 
            // txtRepetirContraseña
            // 
            txtRepetirContraseña.Location = new Point(162, 145);
            txtRepetirContraseña.Name = "txtRepetirContraseña";
            txtRepetirContraseña.Size = new Size(100, 23);
            txtRepetirContraseña.TabIndex = 5;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(105, 209);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(115, 42);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(115, 181);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 7;
            lblError.Text = "Error";
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 307);
            Controls.Add(lblError);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtRepetirContraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Name = "frmRegistro";
            Text = "frmRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRepetirContraseña;
        private Button btnRegistrarse;
        private Label lblError;
    }
}