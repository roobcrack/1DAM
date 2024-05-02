namespace Gestion_Alumnos
{
    partial class frmAcademia
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
            btnMantenimientoAlumnos = new Button();
            btnMantenimientoCursos = new Button();
            btnMatriculacion = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMantenimientoAlumnos
            // 
            btnMantenimientoAlumnos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMantenimientoAlumnos.Location = new Point(70, 249);
            btnMantenimientoAlumnos.Name = "btnMantenimientoAlumnos";
            btnMantenimientoAlumnos.Size = new Size(198, 23);
            btnMantenimientoAlumnos.TabIndex = 0;
            btnMantenimientoAlumnos.Text = "Mantenimiento de alumnos";
            btnMantenimientoAlumnos.UseVisualStyleBackColor = true;
            btnMantenimientoAlumnos.Click += btMantenimientoAlumnos_Click;
            // 
            // btnMantenimientoCursos
            // 
            btnMantenimientoCursos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMantenimientoCursos.Location = new Point(295, 249);
            btnMantenimientoCursos.Name = "btnMantenimientoCursos";
            btnMantenimientoCursos.Size = new Size(198, 23);
            btnMantenimientoCursos.TabIndex = 1;
            btnMantenimientoCursos.Text = "Mantenimiento de cursos";
            btnMantenimientoCursos.UseVisualStyleBackColor = true;
            btnMantenimientoCursos.Click += btMantenimientoCursos_Click;
            // 
            // btnMatriculacion
            // 
            btnMatriculacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMatriculacion.Location = new Point(518, 249);
            btnMatriculacion.Name = "btnMatriculacion";
            btnMatriculacion.Size = new Size(198, 23);
            btnMatriculacion.TabIndex = 2;
            btnMatriculacion.Text = "Matriculación";
            btnMatriculacion.UseVisualStyleBackColor = true;
            btnMatriculacion.Click += btMatriculacion_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.images;
            pictureBox2.Location = new Point(199, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(395, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // frmAcademia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(pictureBox2);
            Controls.Add(btnMatriculacion);
            Controls.Add(btnMantenimientoCursos);
            Controls.Add(btnMantenimientoAlumnos);
            Name = "frmAcademia";
            Text = "frmAcademia";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMantenimientoAlumnos;
        private Button btnMantenimientoCursos;
        private Button btnMatriculacion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}