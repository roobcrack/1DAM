
using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmRegistro : Form
    {
        private GestionUsuarios gu = new GestionUsuarios();
        public frmRegistro()
        {
            InitializeComponent();
        }

        //Hacer que por defecto se creen como usuarios y en el momento que hagan una publicacion se conviertan en creadores, y administradores
        //solo los puede crear el SUPERADMIN
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtContraseña != txtRepetirContraseña)
            {
                if(gu.GetByName(txtNombre.Text) is null)
                {
                    Usuario u = new Usuario();
                }
                else
                    lblError.Text = "Este nombre ya está en uso";
            }
            else
                lblError.Text = "Las contraseñas no coinciden";
        }
    }
}
