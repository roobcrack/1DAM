using System;
using System.Windows.Forms;

namespace Gestion_Alumnos
{
    public partial class frmAlumnos : Form
    {
        private GestionAlumnos gestionAlumnos = new GestionAlumnos();
        private Alumno alumno;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = gestionAlumnos.GetAll();
        }
        public void MapearNegocioPresentacion(Alumno alumno)
        {
            if (alumno != null)
            {
                txtDni.Text = alumno.Dni;
                txtNombre.Text = alumno.Nombre;
                txtApellidos.Text = alumno.Apellidos;
                txtTelefono.Text = alumno.Telefono;
                txtPoblacion.Text = alumno.Poblacion;
                gestionAlumnos.Alumno = alumno;
            }
            else
            {
                string message = gestionAlumnos.Error();
                if (message == "")
                    message = "No hay mas alumnos en la base de datos";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            MapearNegocioPresentacion(alumno);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            alumno = gestionAlumnos.Primero();
            MapearNegocioPresentacion(alumno);
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            alumno = gestionAlumnos.Ultimo();
            MapearNegocioPresentacion(alumno);
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            alumno = gestionAlumnos.Siguiente();
            MapearNegocioPresentacion(alumno);
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            alumno = gestionAlumnos.Anterior();
            MapearNegocioPresentacion(alumno);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Alumno alumno = MapearPresentacionNegocio();

            // Asignar el alumno actual al objeto gestionAlumnos
            gestionAlumnos.Alumno = alumno;

            // Llamar al método Edit() para editar el alumno
            int resultado = gestionAlumnos.Edit();

            // Verificar el resultado de la edición
            if (resultado > 0)
            {
                // Éxito: Mostrar mensaje de éxito
                MessageBox.Show("Alumno editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView
                dgvAlumnos.DataSource = gestionAlumnos.GetAll();
            }
            else if (resultado == 0)
            {
                // No se realizaron cambios: Mostrar mensaje informativo
                MessageBox.Show("No se realizaron cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Error: Mostrar mensaje de error
                MessageBox.Show("Error al editar alumno. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
}
