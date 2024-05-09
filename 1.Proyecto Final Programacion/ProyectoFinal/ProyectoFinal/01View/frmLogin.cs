using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmLogin : Form
    {
        private GestionUsuarios gu = new GestionUsuarios();
        private Usuario usuario;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usuario = gu.GetByName(txtNombre.Text);
            if(usuario is not null && usuario.Nombre == txtNombre.Text && 
                usuario.Contraseña == txtContraseña.Text)
            {
                Form frmusUarios = new frmUsuarios(usuario.Rol);
                frmusUarios.Show();
                this.Hide();
            }
            else
                txtError.Text = "Nombre o contraseña erróneos";
        }
    }
}
