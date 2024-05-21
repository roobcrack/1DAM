namespace ProyectoFinal._01View
{
    partial class frmUsuarios
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
            dgvPerfiles = new DataGridView();
            btnMiUsuario = new Button();
            chxOcultarUsuarios = new CheckBox();
            dgvPublicaciones = new DataGridView();
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            btnSeleccionarPerfiles = new Button();
            btnModificarPublicacion = new Button();
            btnCrearPublicacion = new Button();
            btnEliminarPublicacion = new Button();
            cbxOcultarPerfiles = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            button6 = new Button();
            groupBox2 = new GroupBox();
            button7 = new Button();
            groupBox3 = new GroupBox();
            button8 = new Button();
            lblRolUsuario = new Label();
            lblNombreUsuario = new Label();
            lblNombrePerfil = new Label();
            btnCrearPerfil = new Button();
            btnEliminarPerfil = new Button();
            btnComentar = new Button();
            lblTitulo = new Label();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvPerfiles
            // 
            dgvPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerfiles.Location = new Point(307, 86);
            dgvPerfiles.Name = "dgvPerfiles";
            dgvPerfiles.Size = new Size(227, 392);
            dgvPerfiles.TabIndex = 1;
            dgvPerfiles.CellContentClick += dgvPerfiles_CellContentClick;
            // 
            // btnMiUsuario
            // 
            btnMiUsuario.Location = new Point(25, 36);
            btnMiUsuario.Name = "btnMiUsuario";
            btnMiUsuario.Size = new Size(88, 36);
            btnMiUsuario.TabIndex = 2;
            btnMiUsuario.Text = "Mi usuario";
            btnMiUsuario.UseVisualStyleBackColor = true;
            btnMiUsuario.Click += btnMiUsuario_Click_1;
            // 
            // chxOcultarUsuarios
            // 
            chxOcultarUsuarios.AutoSize = true;
            chxOcultarUsuarios.Location = new Point(25, 484);
            chxOcultarUsuarios.Name = "chxOcultarUsuarios";
            chxOcultarUsuarios.Size = new Size(183, 19);
            chxOcultarUsuarios.TabIndex = 3;
            chxOcultarUsuarios.Text = "Ocultar usuarios no creadores";
            chxOcultarUsuarios.UseVisualStyleBackColor = true;
            chxOcultarUsuarios.CheckedChanged += chxOcultarUsuarios_CheckedChanged;
            // 
            // dgvPublicaciones
            // 
            dgvPublicaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublicaciones.Location = new Point(582, 86);
            dgvPublicaciones.Name = "dgvPublicaciones";
            dgvPublicaciones.Size = new Size(444, 392);
            dgvPublicaciones.TabIndex = 4;
            dgvPublicaciones.CellContentClick += dgvPublicaciones_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 516);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar nombre:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(130, 513);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(110, 23);
            txtNombreUsuario.TabIndex = 6;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // btnSeleccionarPerfiles
            // 
            btnSeleccionarPerfiles.Location = new Point(307, 36);
            btnSeleccionarPerfiles.Name = "btnSeleccionarPerfiles";
            btnSeleccionarPerfiles.Size = new Size(112, 36);
            btnSeleccionarPerfiles.TabIndex = 7;
            btnSeleccionarPerfiles.Text = "Seleccionar todos";
            btnSeleccionarPerfiles.UseVisualStyleBackColor = true;
            btnSeleccionarPerfiles.Click += btnSeleccionarPerfiles_Click;
            // 
            // btnModificarPublicacion
            // 
            btnModificarPublicacion.Location = new Point(680, 495);
            btnModificarPublicacion.Name = "btnModificarPublicacion";
            btnModificarPublicacion.Size = new Size(68, 42);
            btnModificarPublicacion.TabIndex = 8;
            btnModificarPublicacion.Text = "Modificar";
            btnModificarPublicacion.UseVisualStyleBackColor = true;
            btnModificarPublicacion.Click += btnModificarPublicacion_Click;
            // 
            // btnCrearPublicacion
            // 
            btnCrearPublicacion.Location = new Point(606, 494);
            btnCrearPublicacion.Name = "btnCrearPublicacion";
            btnCrearPublicacion.Size = new Size(68, 42);
            btnCrearPublicacion.TabIndex = 9;
            btnCrearPublicacion.Text = "Crear";
            btnCrearPublicacion.UseVisualStyleBackColor = true;
            btnCrearPublicacion.Click += btnCrearPublicacion_Click;
            // 
            // btnEliminarPublicacion
            // 
            btnEliminarPublicacion.Location = new Point(754, 495);
            btnEliminarPublicacion.Name = "btnEliminarPublicacion";
            btnEliminarPublicacion.Size = new Size(68, 42);
            btnEliminarPublicacion.TabIndex = 10;
            btnEliminarPublicacion.Text = "Eliminar";
            btnEliminarPublicacion.UseVisualStyleBackColor = true;
            btnEliminarPublicacion.Click += btnEliminarPublicacion_Click;
            // 
            // cbxOcultarPerfiles
            // 
            cbxOcultarPerfiles.AutoSize = true;
            cbxOcultarPerfiles.Location = new Point(307, 484);
            cbxOcultarPerfiles.Name = "cbxOcultarPerfiles";
            cbxOcultarPerfiles.Size = new Size(189, 19);
            cbxOcultarPerfiles.TabIndex = 11;
            cbxOcultarPerfiles.Text = "Ocultar perfiles sin publicacion";
            cbxOcultarPerfiles.UseVisualStyleBackColor = true;
            cbxOcultarPerfiles.CheckedChanged += cbxOcultarPerfiles_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(25, 552);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 64);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrar usuarios";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(7, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Ocultar admins";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button6
            // 
            button6.Location = new Point(120, 16);
            button6.Name = "button6";
            button6.Size = new Size(92, 42);
            button6.TabIndex = 13;
            button6.Text = "Eliminar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Location = new Point(343, 552);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 64);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administrar perfiles";
            // 
            // button7
            // 
            button7.Location = new Point(31, 16);
            button7.Name = "button7";
            button7.Size = new Size(92, 42);
            button7.TabIndex = 13;
            button7.Text = "Eliminar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Location = new Point(723, 552);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(165, 64);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Administrar publicaciones";
            // 
            // button8
            // 
            button8.Location = new Point(37, 16);
            button8.Name = "button8";
            button8.Size = new Size(92, 42);
            button8.TabIndex = 13;
            button8.Text = "Eliminar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Location = new Point(186, 47);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(66, 15);
            lblRolUsuario.TabIndex = 16;
            lblRolUsuario.Text = "Rol usuario";
            lblRolUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(441, 47);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(93, 15);
            lblNombreUsuario.TabIndex = 17;
            lblNombreUsuario.Text = "Nombre usuario";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNombrePerfil
            // 
            lblNombrePerfil.AutoSize = true;
            lblNombrePerfil.Location = new Point(582, 57);
            lblNombrePerfil.Name = "lblNombrePerfil";
            lblNombrePerfil.Size = new Size(81, 15);
            lblNombrePerfil.TabIndex = 18;
            lblNombrePerfil.Text = "Nombre prefil";
            lblNombrePerfil.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCrearPerfil
            // 
            btnCrearPerfil.Location = new Point(343, 509);
            btnCrearPerfil.Name = "btnCrearPerfil";
            btnCrearPerfil.Size = new Size(68, 42);
            btnCrearPerfil.TabIndex = 21;
            btnCrearPerfil.Text = "Crear";
            btnCrearPerfil.UseVisualStyleBackColor = true;
            btnCrearPerfil.Click += btnCrearPerfil_Click;
            // 
            // btnEliminarPerfil
            // 
            btnEliminarPerfil.Location = new Point(429, 509);
            btnEliminarPerfil.Name = "btnEliminarPerfil";
            btnEliminarPerfil.Size = new Size(68, 42);
            btnEliminarPerfil.TabIndex = 22;
            btnEliminarPerfil.Text = "Eliminar";
            btnEliminarPerfil.UseVisualStyleBackColor = true;
            btnEliminarPerfil.Click += btnEliminarPerfil_Click;
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(828, 494);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(175, 42);
            btnComentar.TabIndex = 25;
            btnComentar.Text = "Ver comentarios / Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            btnComentar.Click += btnComentar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(910, 57);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(116, 15);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Nombre publicacion";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1058, 24);
            menuStrip1.TabIndex = 30;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(117, 22);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(25, 86);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(227, 392);
            dgvUsuarios.TabIndex = 31;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick_1;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 637);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblTitulo);
            Controls.Add(btnComentar);
            Controls.Add(btnEliminarPerfil);
            Controls.Add(btnCrearPerfil);
            Controls.Add(lblNombrePerfil);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblRolUsuario);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cbxOcultarPerfiles);
            Controls.Add(btnEliminarPublicacion);
            Controls.Add(btnCrearPublicacion);
            Controls.Add(btnModificarPublicacion);
            Controls.Add(btnSeleccionarPerfiles);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label1);
            Controls.Add(dgvPublicaciones);
            Controls.Add(chxOcultarUsuarios);
            Controls.Add(btnMiUsuario);
            Controls.Add(dgvPerfiles);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUsuarios";
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvPerfiles;
        private Button btnMiUsuario;
        private CheckBox chxOcultarUsuarios;
        private DataGridView dgvPublicaciones;
        private Label label1;
        private TextBox txtNombreUsuario;
        private Button btnSeleccionarPerfiles;
        private Button btnModificarPublicacion;
        private Button btnCrearPublicacion;
        private Button btnEliminarPublicacion;
        private CheckBox cbxOcultarPerfiles;
        private GroupBox groupBox1;
        private Button button6;
        private GroupBox groupBox2;
        private Button button7;
        private GroupBox groupBox3;
        private Button button8;
        private Label lblRolUsuario;
        private Label lblNombreUsuario;
        private Label lblNombrePerfil;
        private Button btnCrearPerfil;
        private Button btnEliminarPerfil;
        private CheckBox checkBox1;
        private Button btnComentar;
        private Label lblTitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private DataGridView dgvUsuarios;
    }
}