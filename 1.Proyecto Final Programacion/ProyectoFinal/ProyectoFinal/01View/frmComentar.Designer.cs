namespace ProyectoFinal._01View
{
    partial class frmComentar
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
            dgvComentarios = new DataGridView();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            txtComentario = new TextBox();
            btnComentar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).BeginInit();
            SuspendLayout();
            // 
            // dgvComentarios
            // 
            dgvComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComentarios.Location = new Point(410, 25);
            dgvComentarios.Name = "dgvComentarios";
            dgvComentarios.Size = new Size(562, 398);
            dgvComentarios.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.Location = new Point(44, 61);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(81, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "lblTitulo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(44, 132);
            lblDescripcion.MaximumSize = new Size(350, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(38, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "label2";
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(410, 455);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(446, 23);
            txtComentario.TabIndex = 4;
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(862, 445);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(94, 41);
            btnComentar.TabIndex = 5;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            btnComentar.Click += btnComentar_Click;
            // 
            // frmComentar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 518);
            Controls.Add(btnComentar);
            Controls.Add(txtComentario);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(dgvComentarios);
            Name = "frmComentar";
            Text = "Comentar";
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvComentarios;
        private Label lblTitulo;
        private Label lblDescripcion;
        private TextBox txtComentario;
        private Button btnComentar;
    }
}