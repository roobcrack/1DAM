using ProyectoFinal._02Administration;
using ProyectoFinal._03Data;
using System;
using System.Windows.Forms;

namespace ProyectoFinal._01View
{
    public partial class frmUsuarios : Form
    {
        public Usuario usuarioActual;
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
            if (usuarioActual.Rol != "administrador")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            dgvUsuarios.Columns.Remove("contraseña");
            dgvUsuarios.Columns.Remove("rol");
            dgvUsuarios.Columns["idusuario"].Width = 85;
        }

        //////GESTION USUARIOS
        private void btnMiUsuario_Click_1(object sender, EventArgs e)
        {
            SeleccionarFilaUsuario(usuarioActual.IdUsuario);
            gu.Usuario = usuarioActual;
            txtNombreUsuario.Text = "";
            lblNombreUsuario.Text = gu.Usuario.Nombre;
            gp.Perfil = new Perfil();
            lblNombrePerfil.Text = "Nombre perfil";
            MostrarPerfiles();
            if (gpu.GetAllFromUser(gu.Usuario.IdUsuario).Count <= 0)
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
            gu.Usuario = new Usuario();
            gu.Filtrar(chxOcultarUsuarios.Checked, checkBox1.Checked, txtNombreUsuario.Text);
            MostrarUsuarios();
        }
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            gu.Usuario = new Usuario();
            gu.Filtrar(chxOcultarUsuarios.Checked, checkBox1.Checked, txtNombreUsuario.Text);
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = gu.Usuarios;
        }
        private void dgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsuarios.Rows[e.RowIndex];

            Usuario usuario = new Usuario()
            {
                IdUsuario = Convert.ToString(selectedRow.Cells["idusuario"].Value),
                Nombre = Convert.ToString(selectedRow.Cells["nombre"].Value)
            };
            gu.Usuario = gu.GetByName(usuario.Nombre);

            lblNombreUsuario.Text = gu.Usuario.Nombre;
            MostrarPerfiles();
        }
        //////GESTION PERFILES
        private void MostrarPerfiles()
        {
            if (gu.Usuario is not null)
                gp.Filtrar(cbxOcultarPerfiles.Checked, gu.Usuario.IdUsuario, gpu);
            dgvPerfiles.DataSource = gp.Perfiles;
            dgvPerfiles.Columns.Remove("idusuario");
            dgvPerfiles.Columns["idperfil"].Width = 40;
            MostrarPublicaciones("");
            if (gu.Usuario is null || gu.Usuario.IdUsuario != usuarioActual.IdUsuario)
            {
                btnCrearPerfil.Enabled = false;
                btnEliminarPerfil.Enabled = false;
                btnCrearPublicacion.Enabled = false;
                btnEliminarPublicacion.Enabled = false;
                btnModificarPublicacion.Enabled = false;
            }
            else
            {
                btnCrearPerfil.Enabled = true;
                btnEliminarPerfil.Enabled = true;
                btnCrearPublicacion.Enabled = true;
                btnEliminarPublicacion.Enabled = true;
                btnModificarPublicacion.Enabled = true;
            }
        }
        private void cbxOcultarPerfiles_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPerfiles();
        }
        private void btnSeleccionarPerfiles_Click(object sender, EventArgs e)
        {
            if (gu.Usuario != null)
                dgvPublicaciones.DataSource = gpu.GetAllFromUser(gu.Usuario.IdUsuario);
            lblNombrePerfil.Text = "todos";
            foreach (DataGridViewRow row in dgvPerfiles.Rows)
            {
                row.Cells[dgvPerfiles.Columns["idperfil"].Index].Selected = true;
            }
        }
        private void dgvPerfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPerfiles.Rows[e.RowIndex];

            Perfil p = new Perfil()
            {
                IdPerfil = Convert.ToString(selectedRow.Cells["idperfil"].Value)
            };
            gp.Perfil = gp.GetById(p.IdPerfil);

            lblNombrePerfil.Text = gp.Perfil.NombrePerfil;
            MostrarPublicaciones(gp.Perfil.IdPerfil);
        }
        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (gp.Perfil is not null)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro? Se borraran las publicaciones asociadas."
                    , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if (VerificarOperacion(gp.Eliminar()))
                    {
                        gp.ActualizarId();
                        MostrarPerfiles();
                        gp.Perfil = new Perfil();
                        lblNombrePerfil.Text = "Nombre perfil";
                    }
                }
            }
            else
                MessageError("Seleccione un perfil");
        }
        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            if (gu.Usuario is not null)
            {
                frmCrearPerfil frm = new frmCrearPerfil(gu.Usuario.IdUsuario);
                frm.ShowDialog();
                if (frm.Perfil is not null && !string.IsNullOrEmpty(frm.Perfil.NombrePerfil))
                {
                    gp.Perfil = frm.Perfil;
                    if (VerificarOperacion(gp.Insertar()))
                    {
                        MostrarPerfiles();
                        lblNombrePerfil.Text = gp.Perfil.NombrePerfil;
                    }
                }
            }
            else
                MessageError("Seleccione un usuario");
        }
        //////GESTION PUBLICACIONES
        private void MostrarPublicaciones(string id)
        {
            dgvPublicaciones.DataSource = gpu.GetAll(id);
            dgvPublicaciones.Columns.Remove("idperfil");
            dgvPublicaciones.Columns["idpublicacion"].Width = 40;
            dgvPublicaciones.Columns["descripcion"].Width = 250;
        }
        private void dgvPublicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPublicaciones.Rows[e.RowIndex];

            Publicacion p = new Publicacion()
            {
                IdPublicacion = Convert.ToString(selectedRow.Cells["idpublicacion"].Value)
            };
            gpu.Publicacion = gpu.GetById(p.IdPublicacion);

            lblTitulo.Text = gpu.Publicacion.Titulo;
        }
        private void btnCrearPublicacion_Click(object sender, EventArgs e)
        {
            if (gp.Perfil is not null)
            {
                frmCrearPublicacion frm = new frmCrearPublicacion(gp.Perfil.IdPerfil, new Publicacion());
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.Publicacion.Titulo))
                {
                    gpu.Publicacion = frm.Publicacion;
                    if (VerificarOperacion(gpu.Insertar()))
                    {
                        MostrarPublicaciones(gp.Perfil.IdPerfil);
                        lblTitulo.Text = gpu.Publicacion.Titulo;
                    }
                }
            }
            else
                MessageError("Seleccione un perfil");
        }
        private void btnModificarPublicacion_Click(object sender, EventArgs e)
        {
            if (gpu.Publicacion is not null)
            {
                frmCrearPublicacion frm = new frmCrearPublicacion(gp.Perfil.IdPerfil, gpu.Publicacion);
                frm.ShowDialog();
                if (!string.IsNullOrEmpty(frm.Publicacion.Titulo))
                {
                    gpu.Publicacion = frm.Publicacion;
                    if (VerificarOperacion(gpu.Modificar()))
                    {
                        MostrarPublicaciones(gp.Perfil.IdPerfil);
                        lblTitulo.Text = gpu.Publicacion.Titulo;
                    }
                }
            }
            else
                MessageError("Seleccione una publicacion");
        }
        private void btnEliminarPublicacion_Click(object sender, EventArgs e)
        {
            if (gpu.Publicacion is not null)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if (VerificarOperacion(gpu.Eliminar()))
                    {
                        gpu.ActualizarId();
                        MostrarPublicaciones(gp.Perfil.IdPerfil);
                        gpu.Publicacion = new Publicacion();
                        lblTitulo.Text = "Nombre publicacion";
                    }
                }
            }
            else
                MessageError("Seleccione una publicacion");
        }
        //////GESTION COMENTARIOS
        private void btnComentar_Click(object sender, EventArgs e)
        {
            if (gpu.Publicacion is not null)
            {
                frmComentar frm = new frmComentar(gpu.Publicacion);
                frm.Show();
            }
        }

        //////GESTION ADMINISTRADOR
        private void button6_Click(object sender, EventArgs e)
        {
            if (gu.Usuario.IdUsuario is not null && gu.Usuario != usuarioActual)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro? Se borraran las publicaciones asociadas y perfiles asociados."
                    , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if (VerificarOperacion(gu.Eliminar()))
                    {
                        gu.ActualizarId();
                        gu.Usuarios = gu.GetAll();
                        MostrarUsuarios();
                        gu.Usuario = new Usuario();
                        lblNombreUsuario.Text = "Nombre usuario";
                    }
                }
            }
            else
                MessageError("Seleccione un usuario");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (gp.Perfil is not null)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro? Se borraran las publicaciones asociadas."
                    , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if (VerificarOperacion(gp.Eliminar()))
                    {
                        gp.ActualizarId();
                        MostrarPerfiles();
                        gp.Perfil = new Perfil();
                        lblNombrePerfil.Text = "Nombre perfil";
                    }
                }
            }
            else
                MessageError("Seleccione un perfil");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (gpu.Publicacion is not null)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if (VerificarOperacion(gpu.Eliminar()))
                    {
                        gpu.ActualizarId();
                        MostrarPublicaciones(gp.Perfil.IdPerfil);
                        gpu.Publicacion = new Publicacion();
                        lblTitulo.Text = "Nombre publicacion";
                    }
                }
            }
            else
                MessageError("Seleccione una publicacion");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gu.Filtrar(chxOcultarUsuarios.Checked, checkBox1.Checked, txtNombreUsuario.Text);
            MostrarUsuarios();
        }


        //////GESTION GENERAL
        private void MessageError(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool VerificarOperacion(int resultado)
        {
            switch (resultado)
            {
                case 1:
                    MessageBox.Show("Se ha realizado correctamente", "Correcto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0:
                    MessageError("No se han realizado cambios");
                    break;
                default:
                    MessageError("Ha ocurrido un error");
                    break;
            }
            return resultado > 0;
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarioActual = null;
            this.Close();
        }
    }
}
