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
            this.btnMantenimientoAlumnos = new System.Windows.Forms.Button();
            this.btnMantenimientoCursos = new System.Windows.Forms.Button();
            this.btnMatriculacion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMantenimientoAlumnos
            // 
            this.btnMantenimientoAlumnos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMantenimientoAlumnos.Location = new System.Drawing.Point(70, 249);
            this.btnMantenimientoAlumnos.Name = "btnMantenimientoAlumnos";
            this.btnMantenimientoAlumnos.Size = new System.Drawing.Size(198, 23);
            this.btnMantenimientoAlumnos.TabIndex = 0;
            this.btnMantenimientoAlumnos.Text = "Mantenimiento de alumnos";
            this.btnMantenimientoAlumnos.UseVisualStyleBackColor = true;
            this.btnMantenimientoAlumnos.Click += new System.EventHandler(this.btnMantenimientoAlumnos_Click);
            // 
            // btnMantenimientoCursos
            // 
            this.btnMantenimientoCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMantenimientoCursos.Location = new System.Drawing.Point(295, 249);
            this.btnMantenimientoCursos.Name = "btnMantenimientoCursos";
            this.btnMantenimientoCursos.Size = new System.Drawing.Size(198, 23);
            this.btnMantenimientoCursos.TabIndex = 1;
            this.btnMantenimientoCursos.Text = "Mantenimiento de cursos";
            this.btnMantenimientoCursos.UseVisualStyleBackColor = true;
            this.btnMantenimientoCursos.Click += new System.EventHandler(this.btnMantenimientoCursos_Click);
            // 
            // btnMatriculacion
            // 
            this.btnMatriculacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMatriculacion.Location = new System.Drawing.Point(518, 249);
            this.btnMatriculacion.Name = "btnMatriculacion";
            this.btnMatriculacion.Size = new System.Drawing.Size(198, 23);
            this.btnMatriculacion.TabIndex = 2;
            this.btnMatriculacion.Text = "Matriculación";
            this.btnMatriculacion.UseVisualStyleBackColor = true;
            this.btnMatriculacion.Click += new System.EventHandler(this.btnMatriculacion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_Alumnos.Properties.Resources.images1;
            this.pictureBox2.Location = new System.Drawing.Point(189, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // frmAcademia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMatriculacion);
            this.Controls.Add(this.btnMantenimientoCursos);
            this.Controls.Add(this.btnMantenimientoAlumnos);
            this.Name = "frmAcademia";
            this.Text = "frmAcademia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMantenimientoAlumnos;
        private Button btnMantenimientoCursos;
        private Button btnMatriculacion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}