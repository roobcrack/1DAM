namespace Gestion_Alumnos
{
    partial class frmMatriculas
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
            dgvAlumnos = new DataGridView();
            dgvCursos = new DataGridView();
            txtDni = new TextBox();
            txtCodigo = new TextBox();
            btnMatricular = new Button();
            btnDesmatricular = new Button();
            btnAlumnos = new Button();
            btnAlumnosCurso = new Button();
            btnCursosAlumno = new Button();
            btnCursos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(33, 59);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(465, 308);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick_1;
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(559, 59);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.Size = new Size(461, 308);
            dgvCursos.TabIndex = 1;
            dgvCursos.CellContentClick += dgvCursos_CellContentClick;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(398, 30);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(559, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // btnMatricular
            // 
            btnMatricular.Location = new Point(708, 15);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(138, 38);
            btnMatricular.TabIndex = 4;
            btnMatricular.Text = "Matricular alumno";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // btnDesmatricular
            // 
            btnDesmatricular.Location = new Point(882, 15);
            btnDesmatricular.Name = "btnDesmatricular";
            btnDesmatricular.Size = new Size(138, 38);
            btnDesmatricular.TabIndex = 5;
            btnDesmatricular.Text = "Desmatricular alumno";
            btnDesmatricular.UseVisualStyleBackColor = true;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(33, 387);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(202, 62);
            btnAlumnos.TabIndex = 6;
            btnAlumnos.Text = "Ver todos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnAlumnosCurso
            // 
            btnAlumnosCurso.Location = new Point(296, 387);
            btnAlumnosCurso.Name = "btnAlumnosCurso";
            btnAlumnosCurso.Size = new Size(202, 62);
            btnAlumnosCurso.TabIndex = 7;
            btnAlumnosCurso.Text = "Ver alumnos del curso";
            btnAlumnosCurso.UseVisualStyleBackColor = true;
            // 
            // btnCursosAlumno
            // 
            btnCursosAlumno.Location = new Point(559, 387);
            btnCursosAlumno.Name = "btnCursosAlumno";
            btnCursosAlumno.Size = new Size(202, 62);
            btnCursosAlumno.TabIndex = 8;
            btnCursosAlumno.Text = "Ver cursos del alumno";
            btnCursosAlumno.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(818, 387);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(202, 62);
            btnCursos.TabIndex = 9;
            btnCursos.Text = "Ver todos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // frmMatriculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 482);
            Controls.Add(btnCursos);
            Controls.Add(btnCursosAlumno);
            Controls.Add(btnAlumnosCurso);
            Controls.Add(btnAlumnos);
            Controls.Add(btnDesmatricular);
            Controls.Add(btnMatricular);
            Controls.Add(txtCodigo);
            Controls.Add(txtDni);
            Controls.Add(dgvCursos);
            Controls.Add(dgvAlumnos);
            Name = "frmMatriculas";
            Text = "frmMatriculas";
            Load += frmMatriculas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private DataGridView dgvCursos;
        private TextBox txtDni;
        private TextBox txtCodigo;
        private Button btnMatricular;
        private Button btnDesmatricular;
        private Button btnAlumnos;
        private Button btnAlumnosCurso;
        private Button btnCursosAlumno;
        private Button btnCursos;
    }
}