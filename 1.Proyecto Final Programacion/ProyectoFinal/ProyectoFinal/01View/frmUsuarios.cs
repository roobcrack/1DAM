using ProyectoFinal._02Administration;

namespace ProyectoFinal._01View
{
    public partial class frmUsuarios : Form
    {
        private string rol { get; set; }
        private GestionUsuarios gu = new GestionUsuarios();
        public frmUsuarios(string rol)
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = gu.GetAll();
        }
    }
}
