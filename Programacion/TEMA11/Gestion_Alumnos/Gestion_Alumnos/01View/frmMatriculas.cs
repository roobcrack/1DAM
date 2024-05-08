namespace Gestion_Alumnos
{
    public partial class frmMatriculas : Form
    {
        private GestionAlumnos gestionAlumnos = new GestionAlumnos();
        private GestionCursos gestionCursos = new GestionCursos();
        private Matricula matricula;
        public frmMatriculas()
        {
            InitializeComponent();
        }

        private void frmMatriculas_Load(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
            dgvCursos.DataSource = gestionCursos.GetAll();
        }
        public void MapearNegocioPresentacionAlumno(Alumno alumno)
        {
            if (alumno != null)
                txtDni.Text = alumno.Dni;
            else
                MessageBox.Show(gestionAlumnos.Error(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MapearNegocioPresentacionCurso(Curso curso)
        {
            if (curso != null)
                txtCodigo.Text = curso.Codigo;
            else
                MessageBox.Show(gestionCursos.Error(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public Matricula MapearPresentacionNegocio()
        {
            matricula = new Matricula();
            matricula.Dni = txtDni.Text;
            matricula.Codigo = txtCodigo.Text;

            return matricula;
        }

        private void dgvAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvAlumnos.Rows[e.RowIndex];

            Alumno alumno = new Alumno()
            {
                Dni = Convert.ToString(selectedRow.Cells["Dni"].Value),
                Nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value),
                Apellidos = Convert.ToString(selectedRow.Cells["Apellidos"].Value),
                Telefono = Convert.ToString(selectedRow.Cells["Telefono"].Value),
                Poblacion = Convert.ToString(selectedRow.Cells["Poblacion"].Value)
            };

            MapearNegocioPresentacionAlumno(alumno);
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvCursos.Rows[e.RowIndex];

            Curso curso = new Curso()
            {
                Codigo = Convert.ToString(selectedRow.Cells["codigo"].Value),
                Titulo = Convert.ToString(selectedRow.Cells["titulo"].Value),
                Num_plazas = Convert.ToString(selectedRow.Cells["num_plazas"].Value),
                Precio = Convert.ToString(selectedRow.Cells["precio"].Value),
                Lugar_realizacion = Convert.ToString(selectedRow.Cells["lugar_realizacion"].Value)
            };

            MapearNegocioPresentacionCurso(curso);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = gestionCursos.GetAll();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {

            }
        }
    }
}
