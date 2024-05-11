using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            GestionUsuarios gu = new GestionUsuarios();
            Usuario usuario = gu.GetByName(txtNombre.Text);
            if (usuario is not null && usuario.Nombre == txtNombre.Text &&
                usuario.Contraseña == txtContraseña.Text)
            {
                Form frmusUarios = new frmUsuarios(usuario);
                frmusUarios.Show();
                this.Hide();
            }
            else
                txtError.Text = "Nombre o contraseña erróneos";
        }

        private void lblCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }
    }
}
