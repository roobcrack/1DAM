namespace ProyectoFinal._01View
{
    partial class frmCrearPublicacion
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
            label1 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            btnCompletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(136, 41);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(136, 79);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(91, 134);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(106, 44);
            btnCompletar.TabIndex = 6;
            btnCompletar.Text = "Completar";
            btnCompletar.UseVisualStyleBackColor = true;
            btnCompletar.Click += btnCompletar_Click;
            // 
            // frmCrearPublicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 257);
            Controls.Add(btnCompletar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCrearPublicacion";
            Text = "Crear publicacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private Button btnCompletar;
    }
}