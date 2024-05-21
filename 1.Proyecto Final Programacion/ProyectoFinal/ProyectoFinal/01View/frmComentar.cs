
using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmComentar : Form
    {
        private GestionComentarios gc = new GestionComentarios();
        public Comentario Comentario { get; set; }
        private Publicacion publicacion { get; set; }
        public frmComentar(Publicacion publicacion)
        {
            InitializeComponent();
            this.publicacion = publicacion;
            lblTitulo.Text = publicacion.Titulo;
            lblDescripcion.Text = publicacion.Descripcion;
            mostrarComentarios();
            dgvComentarios.Columns.Remove("idpublicacion");
            dgvComentarios.Columns["idcomentario"].Width = 30;
            dgvComentarios.Columns["contenido"].Width = 400;
        }
        private void mostrarComentarios()
        {
            dgvComentarios.DataSource = gc.GetAll(publicacion.IdPublicacion);
        }
        private void btnComentar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtComentario.Text))
            {
                Comentario = new Comentario(Convert.ToString(gc.GetAllAll().Count + 1),
                    txtComentario.Text, publicacion.IdPublicacion);
                gc.Comentario = Comentario;
                gc.Comentar();
                mostrarComentarios();
                txtComentario.Text = "";
            }
            else
                MessageBox.Show("Inserte un comentario", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
    }
}
