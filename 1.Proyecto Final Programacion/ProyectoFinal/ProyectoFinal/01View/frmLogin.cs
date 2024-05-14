using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmLogin : Form
    {
        public Usuario Usuario;

        public frmLogin()
        {
            InitializeComponent();
        }
        public void BtnEntrar_Click(object sender, EventArgs e)
        {
            GestionUsuarios gu = new GestionUsuarios();
            Usuario = gu.GetByName(txtNombre.Text);
            if (Usuario is not null && Usuario.Nombre == txtNombre.Text &&
                Usuario.Contraseña == txtContraseña.Text)
            {
                this.Hide();
            }
            else
                txtError.Text = "Nombre o contraseña erróneos";
        }
        /*
        private void lblCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }*/
    }
}
