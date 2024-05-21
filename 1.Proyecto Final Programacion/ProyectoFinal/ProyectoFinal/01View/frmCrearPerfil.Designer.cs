namespace ProyectoFinal._01View
{
    partial class frmCrearPerfil
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
            btnCrear = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtResumen = new TextBox();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(139, 150);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(114, 46);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 58);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Resumen:";
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(108, 97);
            txtResumen.Name = "txtResumen";
            txtResumen.Size = new Size(252, 23);
            txtResumen.TabIndex = 4;
            // 
            // frmCrearPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 249);
            Controls.Add(txtResumen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnCrear);
            Name = "frmCrearPerfil";
            Text = "Crear Perfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtResumen;
    }
}