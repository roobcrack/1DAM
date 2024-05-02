namespace Gestion_Alumnos
{
    partial class frmCursos
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnFind = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            txtPrecio = new TextBox();
            txtNumeroPlazas = new TextBox();
            txtLugarRealizacion = new TextBox();
            txtTitulo = new TextBox();
            txtCodigo = new TextBox();
            lblPrecio = new Label();
            lnlNumPlazas = new Label();
            lblLugarRealizacion = new Label();
            lblTitulo = new Label();
            lblCodigo = new Label();
            dgvGestionCursos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionCursos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnUltimo);
            groupBox1.Controls.Add(btnSiguiente);
            groupBox1.Controls.Add(btnAnterior);
            groupBox1.Controls.Add(btnPrimero);
            groupBox1.Location = new Point(35, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(855, 66);
            groupBox1.TabIndex = 21;
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
            // 
            // btnFind
            // 
            btnFind.Location = new Point(652, 22);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(88, 29);
            btnFind.TabIndex = 16;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(546, 22);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 29);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(441, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(336, 22);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(88, 29);
            btnUltimo.TabIndex = 14;
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(229, 22);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(88, 29);
            btnSiguiente.TabIndex = 13;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(116, 22);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(88, 29);
            btnAnterior.TabIndex = 12;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
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
            // txtPrecio
            // 
            txtPrecio.Location = new Point(161, 223);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 20;
            // 
            // txtNumeroPlazas
            // 
            txtNumeroPlazas.Location = new Point(161, 181);
            txtNumeroPlazas.Name = "txtNumeroPlazas";
            txtNumeroPlazas.Size = new Size(100, 23);
            txtNumeroPlazas.TabIndex = 19;
            // 
            // txtLugarRealizacion
            // 
            txtLugarRealizacion.Location = new Point(161, 141);
            txtLugarRealizacion.Name = "txtLugarRealizacion";
            txtLugarRealizacion.Size = new Size(100, 23);
            txtLugarRealizacion.TabIndex = 18;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(161, 100);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 17;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(161, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 16;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(41, 223);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio:";
            // 
            // lnlNumPlazas
            // 
            lnlNumPlazas.AutoSize = true;
            lnlNumPlazas.Location = new Point(41, 181);
            lnlNumPlazas.Name = "lnlNumPlazas";
            lnlNumPlazas.Size = new Size(102, 15);
            lnlNumPlazas.TabIndex = 14;
            lnlNumPlazas.Text = "Número de plazas";
            // 
            // lblLugarRealizacion
            // 
            lblLugarRealizacion.AutoSize = true;
            lblLugarRealizacion.Location = new Point(41, 141);
            lblLugarRealizacion.Name = "lblLugarRealizacion";
            lblLugarRealizacion.Size = new Size(115, 15);
            lblLugarRealizacion.TabIndex = 13;
            lblLugarRealizacion.Text = "Lugar de realización:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(41, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Título:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(41, 61);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 11;
            lblCodigo.Text = "Código:";
            // 
            // dgvGestionCursos
            // 
            dgvGestionCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionCursos.Location = new Point(345, 29);
            dgvGestionCursos.Name = "dgvGestionCursos";
            dgvGestionCursos.RowTemplate.Height = 25;
            dgvGestionCursos.Size = new Size(545, 294);
            dgvGestionCursos.TabIndex = 22;
            dgvGestionCursos.CellContentClick += dgvGestionCursos_CellContentClick;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(dgvGestionCursos);
            Controls.Add(groupBox1);
            Controls.Add(txtPrecio);
            Controls.Add(txtNumeroPlazas);
            Controls.Add(txtLugarRealizacion);
            Controls.Add(txtTitulo);
            Controls.Add(txtCodigo);
            Controls.Add(lblPrecio);
            Controls.Add(lnlNumPlazas);
            Controls.Add(lblLugarRealizacion);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Name = "frmCursos";
            Text = "frmCursos";
            Load += frmCursos_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGestionCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnFind;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtPrecio;
        private TextBox txtNumeroPlazas;
        private TextBox txtLugarRealizacion;
        private TextBox txtTitulo;
        private TextBox txtCodigo;
        private Label lblPrecio;
        private Label lnlNumPlazas;
        private Label lblLugarRealizacion;
        private Label lblTitulo;
        private Label lblCodigo;
        private DataGridView dgvGestionCursos;
    }
}