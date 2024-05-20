using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmCrearPublicacion : Form
    {
        public Publicacion Publicacion { get; set; }
        private GestionPublicaciones gpu = new GestionPublicaciones();
        private string idperfil { get; set; }
        public frmCrearPublicacion(string idperfil, Publicacion publicacion)
        {
            InitializeComponent();
            this.Publicacion = publicacion;
            this.idperfil = idperfil;
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Publicacion.Titulo))
                Publicacion.IdPublicacion = Convert.ToString(gpu.GetAllAll().Count + 1);

            Publicacion = new Publicacion(Publicacion.IdPublicacion, txtTitulo.Text,
                txtDescripcion.Text, txtImagen.Text, idperfil);
            this.Close();
        }
    }
}
