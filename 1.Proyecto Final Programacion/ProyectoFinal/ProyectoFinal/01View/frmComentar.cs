
using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmComentar : Form
    {
        private GestionComentarios gc = new GestionComentarios();
        public Comentario Comentario { get; set; }
        private string idpublicacion {  get; set; }
        public frmComentar(string idpublicacion)
        {
            InitializeComponent();
            this.idpublicacion = idpublicacion;
        }
    }
}
