using ProyectoFinal._02Administration;
using System;
using System.Windows.Forms;

namespace ProyectoFinal._01View
{
    public partial class frmUsuarios : Form
    {
        private Usuario usuarioActual;
        private GestionUsuarios gu = new GestionUsuarios();
        private GestionPerfiles gp = new GestionPerfiles();
        private GestionPublicaciones gpu = new GestionPublicaciones();

        public frmUsuarios(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblRolUsuario.Text = usuarioActual.Rol;
            MostrarUsuarios();
            MostrarPerfiles();
            MostrarPublicaciones("");
        }

        //////GESTION USUARIOS
        private void btnMiUsuario_Click_1(object sender, EventArgs e)
        {
            SeleccionarFilaUsuario(usuarioActual.IdUsuario);
            gu.Usuario = usuarioActual;
            txtNombreUsuario.Text = "";
            lblNombreUsuario.Text = gu.Usuario.Nombre;
            gp.Filtrar(cbxOcultarPerfiles.Checked, gu.Usuario.IdUsuario, gpu);
            MostrarPerfiles();
            if (gu.Usuario.Rol == "usuario")
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

            gu.Usuario = new Usuario()
            {
                IdUsuario = Convert.ToString(selectedRow.Cells["idusuario"].Value),
                Nombre = Convert.ToString(selectedRow.Cells["nombre"].Value),
                Contraseña = Convert.ToString(selectedRow.Cells["contraseña"].Value),
                Rol = Convert.ToString(selectedRow.Cells["rol"].Value)
            };

            lblNombreUsuario.Text = gu.Usuario.Nombre;
            gp.Filtrar(cbxOcultarPerfiles.Checked, gu.Usuario.IdUsuario, gpu);
            MostrarPerfiles();
        }

        //////GESTION PERFILES
        private void MostrarPerfiles()
        {
            dgvPerfiles.DataSource = gp.Perfiles;
        }
        private void cbxOcultarPerfiles_CheckedChanged(object sender, EventArgs e)
        {
            gp.Filtrar(cbxOcultarPerfiles.Checked, gu.Usuario.IdUsuario, gpu);
            MostrarPerfiles();
        }
        private void btnSeleccionarPerfiles_Click(object sender, EventArgs e)
        {
            if (gu.Usuario != null)
                dgvPublicaciones.DataSource = gpu.GetAllAll(gu.Usuario.IdUsuario);
            lblNombrePerfil.Text = "todos";
            foreach (DataGridViewRow row in dgvPerfiles.Rows)
            {
                row.Cells[dgvPerfiles.Columns["idperfil"].Index].Selected = true;
            }
        }
        private void dgvPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPerfiles.Rows[e.RowIndex];

            gp.Perfil = new Perfil()
            {
                IdPerfil = Convert.ToString(selectedRow.Cells["idperfil"].Value),
                NombrePerfil = Convert.ToString(selectedRow.Cells["nombreperfil"].Value),
                Resumen = Convert.ToString(selectedRow.Cells["resumen"].Value),
                IdUsuario = Convert.ToString(selectedRow.Cells["idusuario"].Value)
            };

            lblNombrePerfil.Text = gp.Perfil.NombrePerfil;
            MostrarPublicaciones(gp.Perfil.IdPerfil);
        }
        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (gp.Perfil is not null)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if (gp.Remove(gu.Usuario.IdUsuario) == 1)
                    {
                        gp.Filtrar(cbxOcultarPerfiles.Checked, gu.Usuario.IdUsuario, gpu);
                        MostrarPerfiles();
                    }
                    else
                        MessageBox.Show("No se ha podido registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            gp.Insert(gu.Usuario.IdUsuario);
            gp.Filtrar(cbxOcultarPerfiles.Checked, gu.Usuario.IdUsuario, gpu);
            MostrarPerfiles();
        }
        //////GESTION PUBLICACIONES
        private void MostrarPublicaciones(string id)
        {
            dgvPublicaciones.DataSource = gpu.GetAll(id);
        }
    }
}
