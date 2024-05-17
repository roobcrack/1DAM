﻿namespace ProyectoFinal._01View
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
            dgvUsuarios = new DataGridView();
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
            txtBuscarTitulo = new TextBox();
            label4 = new Label();
            lblRolUsuario = new Label();
            lblNombreUsuario = new Label();
            lblNombrePerfil = new Label();
            btnCrearPerfil = new Button();
            btnEliminarPerfil = new Button();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(27, 62);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(227, 392);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // dgvPerfiles
            // 
            dgvPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerfiles.Location = new Point(309, 62);
            dgvPerfiles.Name = "dgvPerfiles";
            dgvPerfiles.Size = new Size(227, 392);
            dgvPerfiles.TabIndex = 1;
            dgvPerfiles.CellContentClick += dgvPerfiles_CellContentClick;
            // 
            // btnMiUsuario
            // 
            btnMiUsuario.Location = new Point(27, 12);
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
            chxOcultarUsuarios.Location = new Point(27, 460);
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
            dgvPublicaciones.Location = new Point(584, 62);
            dgvPublicaciones.Name = "dgvPublicaciones";
            dgvPublicaciones.Size = new Size(444, 392);
            dgvPublicaciones.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 492);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar nombre:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(132, 489);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(110, 23);
            txtNombreUsuario.TabIndex = 6;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // btnSeleccionarPerfiles
            // 
            btnSeleccionarPerfiles.Location = new Point(309, 12);
            btnSeleccionarPerfiles.Name = "btnSeleccionarPerfiles";
            btnSeleccionarPerfiles.Size = new Size(112, 36);
            btnSeleccionarPerfiles.TabIndex = 7;
            btnSeleccionarPerfiles.Text = "Seleccionar todos";
            btnSeleccionarPerfiles.UseVisualStyleBackColor = true;
            btnSeleccionarPerfiles.Click += btnSeleccionarPerfiles_Click;
            // 
            // btnModificarPublicacion
            // 
            btnModificarPublicacion.Location = new Point(682, 461);
            btnModificarPublicacion.Name = "btnModificarPublicacion";
            btnModificarPublicacion.Size = new Size(68, 42);
            btnModificarPublicacion.TabIndex = 8;
            btnModificarPublicacion.Text = "Modificar";
            btnModificarPublicacion.UseVisualStyleBackColor = true;
            // 
            // btnCrearPublicacion
            // 
            btnCrearPublicacion.Location = new Point(608, 460);
            btnCrearPublicacion.Name = "btnCrearPublicacion";
            btnCrearPublicacion.Size = new Size(68, 42);
            btnCrearPublicacion.TabIndex = 9;
            btnCrearPublicacion.Text = "Crear";
            btnCrearPublicacion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPublicacion
            // 
            btnEliminarPublicacion.Location = new Point(756, 461);
            btnEliminarPublicacion.Name = "btnEliminarPublicacion";
            btnEliminarPublicacion.Size = new Size(68, 42);
            btnEliminarPublicacion.TabIndex = 10;
            btnEliminarPublicacion.Text = "Eliminar";
            btnEliminarPublicacion.UseVisualStyleBackColor = true;
            // 
            // cbxOcultarPerfiles
            // 
            cbxOcultarPerfiles.AutoSize = true;
            cbxOcultarPerfiles.Location = new Point(309, 460);
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
            groupBox1.Location = new Point(27, 528);
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
            // 
            // button6
            // 
            button6.Location = new Point(120, 16);
            button6.Name = "button6";
            button6.Size = new Size(92, 42);
            button6.TabIndex = 13;
            button6.Text = "Eliminar";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Location = new Point(345, 528);
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
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(txtBuscarTitulo);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(650, 528);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(285, 64);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Administrar publicaciones";
            // 
            // button8
            // 
            button8.Location = new Point(170, 16);
            button8.Name = "button8";
            button8.Size = new Size(92, 42);
            button8.TabIndex = 13;
            button8.Text = "Eliminar";
            button8.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTitulo
            // 
            txtBuscarTitulo.Location = new Point(32, 27);
            txtBuscarTitulo.Name = "txtBuscarTitulo";
            txtBuscarTitulo.Size = new Size(110, 23);
            txtBuscarTitulo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 30);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 19;
            label4.Text = "Id:";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Location = new Point(188, 23);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(66, 15);
            lblRolUsuario.TabIndex = 16;
            lblRolUsuario.Text = "Rol usuario";
            lblRolUsuario.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(443, 23);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(93, 15);
            lblNombreUsuario.TabIndex = 17;
            lblNombreUsuario.Text = "Nombre usuario";
            lblNombreUsuario.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNombrePerfil
            // 
            lblNombrePerfil.AutoSize = true;
            lblNombrePerfil.Location = new Point(947, 23);
            lblNombrePerfil.Name = "lblNombrePerfil";
            lblNombrePerfil.Size = new Size(81, 15);
            lblNombrePerfil.TabIndex = 18;
            lblNombrePerfil.Text = "Nombre prefil";
            lblNombrePerfil.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCrearPerfil
            // 
            btnCrearPerfil.Location = new Point(345, 485);
            btnCrearPerfil.Name = "btnCrearPerfil";
            btnCrearPerfil.Size = new Size(68, 42);
            btnCrearPerfil.TabIndex = 21;
            btnCrearPerfil.Text = "Crear";
            btnCrearPerfil.UseVisualStyleBackColor = true;
            btnCrearPerfil.Click += btnCrearPerfil_Click;
            // 
            // btnEliminarPerfil
            // 
            btnEliminarPerfil.Location = new Point(431, 485);
            btnEliminarPerfil.Name = "btnEliminarPerfil";
            btnEliminarPerfil.Size = new Size(68, 42);
            btnEliminarPerfil.TabIndex = 22;
            btnEliminarPerfil.Text = "Eliminar";
            btnEliminarPerfil.UseVisualStyleBackColor = true;
            btnEliminarPerfil.Click += btnEliminarPerfil_Click;
            // 
            // button1
            // 
            button1.Location = new Point(830, 461);
            button1.Name = "button1";
            button1.Size = new Size(68, 42);
            button1.TabIndex = 24;
            button1.Text = "Comentar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(904, 460);
            button2.Name = "button2";
            button2.Size = new Size(101, 42);
            button2.TabIndex = 25;
            button2.Text = "Ver comentarios";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "id", "titulo", "fecha de publicacion" });
            comboBox1.Location = new Point(667, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(584, 28);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 27;
            label2.Text = "Ordenar por: ";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Location = new Point(830, 21);
            button3.Name = "button3";
            button3.Size = new Size(58, 28);
            button3.TabIndex = 28;
            button3.Text = "Filtrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 613);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(dgvUsuarios);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPublicaciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
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
        private TextBox txtBuscarTitulo;
        private Label label4;
        private Button btnCrearPerfil;
        private Button btnEliminarPerfil;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private Button button3;
    }
}