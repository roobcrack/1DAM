namespace Gestion_Alumnos
{
    public partial class frmAcademia : Form
    {
        public frmAcademia()
        {
            InitializeComponent();
        }

        private void btnMantenimientoAlumnos_Click(object sender, EventArgs e)
        {
            Form frmAlumnos = new frmAlumnos();
            frmAlumnos.Show();
        }

        private void btnMantenimientoCursos_Click(object sender, EventArgs e)
        {
            Form frmCursos = new frmCursos();
            frmCursos.Show();
        }

        private void btnMatriculacion_Click(object sender, EventArgs e)
        {
            Form frmMatriculas = new frmMatriculas();
            frmMatriculas.Show();
        }
    }
}
