using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmLogin : Form
    {
        GestionUsuarios gu = new GestionUsuarios();
        public Usuario Usuario;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario = gu.GetByName(txtNombre.Text);

            if (Usuario is not null && Usuario.Nombre == txtNombre.Text &&
                Usuario.Contraseña == txtContraseña.Text)
                this.Close();
            else
            {
                txtError.Text = "Nombre o contraseña erróneos";
                Usuario = null;
            }
        }
        private void lblCrearUsuario_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuario = new Usuario();
            this.Close();
        }
    }
}
