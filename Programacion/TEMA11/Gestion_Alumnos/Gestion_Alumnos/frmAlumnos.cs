using System;
using System.Windows.Forms;

namespace Gestion_Alumnos
{
    public partial class frmAlumnos : Form
    {
        private GestionAlumnos gestionAlumnos = new GestionAlumnos();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        // Método para mapear datos del objeto Alumno a los textBox
        public void MapearNegocioPresentacion(Alumno alumno)
        {
            txtDni.Text = alumno.Dni;
            txtNombre.Text = alumno.Nombre;
            txtApellidos.Text = alumno.Apellidos;
            txtTelefono.Text = alumno.Telefono;
            txtPoblacion.Text = alumno.Poblacion;
        }

        // Método para mapear datos de los textBox al objeto Alumno
        public Alumno MapearPresentacionNegocio()
        {
            Alumno alumno = new Alumno();
            alumno.Dni = txtDni.Text;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellidos = txtApellidos.Text;
            alumno.Telefono = txtTelefono.Text;
            alumno.Poblacion = txtPoblacion.Text;

            return alumno;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            // Obtener y cargar la lista de alumnos en el DataGridView
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Obtener el primer alumno y mapear sus datos a los campos de texto
            Alumno primerAlumno = gestionAlumnos.Primero();
            if (primerAlumno != null)
            {
                MapearNegocioPresentacion(primerAlumno);
            }
            else
            {
                // Manejar el caso en el que no se encuentre ningún alumno
                MessageBox.Show("No se encontró ningún alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            if (e.ColumnIndex >= 0 && e.RowIndex < dgvAlumnos.Rows.Count)
            {
                // Obtener el alumno seleccionado en el DataGridView
                DataGridViewRow selectedRow = dgvAlumnos.Rows[e.RowIndex];

                // Declarar el alumno a mapear
                Alumno alumno = new Alumno()
                {
                    Dni = Convert.ToString(selectedRow.Cells["Dni"].Value),
                    Nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value),
                    Apellidos = Convert.ToString(selectedRow.Cells["Apellidos"].Value),
                    Telefono = Convert.ToString(selectedRow.Cells["Poblacion"].Value),
                    Poblacion = Convert.ToString(selectedRow.Cells["Telefono"].Value)
                };
                
                // Cargamos el alumno a la clase de gestión
                gestionAlumnos.Alumno = alumno;

                // Mapear los datos del alumno seleccionado a los campos de texto
                MapearNegocioPresentacion(alumno);
            }
        }
    }
}
