
using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            GestionUsuarios gu = new GestionUsuarios();

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtRepetirContraseña.Text))
                lblError.Text = "Rellena todos los campos";
            else if (gu.GetByName(txtNombre.Text) != null)
                lblError.Text = "Este nombre ya está en uso";
            else if (txtContraseña.Text != txtRepetirContraseña.Text)
                lblError.Text = "Las contraseñas no coinciden";
            else
            {
                gu.Usuario = new Usuario(Convert.ToString(gu.GetAll().Count + 1), txtNombre.Text, txtContraseña.Text, "usuario");
                if (VerificarOperacion(gu.RegistrarUsuario()))
                {                    
                    if (Application.OpenForms["frmLogin"] != null)
                    {
                        Application.OpenForms["frmLogin"].Close();
                    }
                }
            }
        }
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
                    MessageError("No se realizaron cambios");
                    break;
                default:
                    MessageError("Error al conectar");
                    break;
            }
            return resultado > 0;
        }
    }
}
