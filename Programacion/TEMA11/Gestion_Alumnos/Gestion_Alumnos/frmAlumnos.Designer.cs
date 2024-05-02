namespace Gestion_Alumnos
{
    partial class frmAlumnos
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
            lblDni = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblTelefono = new Label();
            lblPoblacion = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtPoblacion = new TextBox();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnFind = new Button();
            btnRemove = new Button();
            btnInsert = new Button();
            btnEdit = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            dgvAlumnos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(67, 80);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(28, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "Dni:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 119);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(67, 160);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(59, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(67, 200);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(67, 242);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(63, 15);
            lblPoblacion.TabIndex = 4;
            lblPoblacion.Text = "Población:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(142, 80);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(142, 160);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(100, 23);
            txtApellidos.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(142, 200);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(142, 242);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(100, 23);
            txtPoblacion.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnUltimo);
            groupBox1.Controls.Add(btnSiguiente);
            groupBox1.Controls.Add(btnAnterior);
            groupBox1.Controls.Add(btnPrimero);
            groupBox1.Location = new Point(34, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(855, 66);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(759, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 29);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(665, 22);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(88, 29);
            btnFind.TabIndex = 16;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(571, 22);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 29);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(477, 22);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(88, 29);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(383, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(289, 22);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(88, 29);
            btnUltimo.TabIndex = 14;
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(195, 22);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(88, 29);
            btnSiguiente.TabIndex = 13;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(101, 22);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(88, 29);
            btnAnterior.TabIndex = 12;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(6, 22);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(88, 29);
            btnPrimero.TabIndex = 11;
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(342, 38);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(547, 294);
            dgvAlumnos.TabIndex = 23;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(dgvAlumnos);
            Controls.Add(groupBox1);
            Controls.Add(txtPoblacion);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(lblPoblacion);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            Load += frmAlumnos_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblTelefono;
        private Label lblPoblacion;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtPoblacion;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnFind;
        private Button btnRemove;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private DataGridView dgvAlumnos;
    }
}