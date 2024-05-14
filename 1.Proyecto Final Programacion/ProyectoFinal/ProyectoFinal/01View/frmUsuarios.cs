﻿using ProyectoFinal._02Administration;
using System;
using System.Windows.Forms;

namespace ProyectoFinal._01View
{
    public partial class frmUsuarios : Form
    {
        private Usuario usuarioActual;
        private GestionUsuarios gu;
        private GestionPerfiles gp;

        public frmUsuarios(Usuario usuario)
        {
            InitializeComponent();
            gu = new GestionUsuarios();
            gp = new GestionPerfiles();
            this.usuarioActual = usuario;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblRolUsuario.Text = usuarioActual.Rol;
            try
            {
                MostrarUsuarios();
                MostrarPerfiles("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////GESTION USUARIOS
        private void btnMiUsuario_Click_1(object sender, EventArgs e)
        {
            SeleccionarFilaUsuario(usuarioActual.IdUsuario);
            gu.Usuario = usuarioActual;
            txtNombreUsuario.Text = "";
            lblNombreUsuario.Text = usuarioActual.Nombre;
<<<<<<< HEAD
=======
            MostrarPerfiles(usuarioActual.IdUsuario);
>>>>>>> 453cbfa003be399e6fb98c5a3546c79b39ba4865
            if (usuarioActual.Rol == "usuario")
                chxOcultarUsuarios.Checked = false;
        }
        private void SeleccionarFilaUsuario(string id)
        {
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (row.Cells["idusuario"].Value.ToString() == id)
                {
                    dgvUsuarios.CurrentCell = row.Cells["idusuario"];
                    break;
                }
            }
        }
        private void chxOcultarUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            gu.Filtrar(chxOcultarUsuarios.Checked, txtNombreUsuario.Text);
            MostrarUsuarios();
        }
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            gu.Filtrar(chxOcultarUsuarios.Checked, txtNombreUsuario.Text);
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = gu.Usuarios;
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsuarios.Rows[e.RowIndex];

            Usuario usuario = new Usuario()
            {
                IdUsuario = Convert.ToString(selectedRow.Cells["idusuario"].Value),
                Nombre = Convert.ToString(selectedRow.Cells["nombre"].Value),
            };
            gu.Usuario = gu.GetByName(usuario.IdUsuario);
            lblNombreUsuario.Text = usuario.Nombre;
        }

        //////GESTION PERFILES
        private void MostrarPerfiles(string id)
        {
            dgvPerfiles.DataSource = gp.GetAll(id);
        }


    }
}
