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
                SeleccionarFilaAlumno(alumno.Dni);
            }
            else
            {
                string message = gestionAlumnos.Error();
                MessageBox.Show(string.IsNullOrEmpty(message) ? "No hay más alumnos en la base de datos" :
                    message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Alumno MapearPresentacionNegocio()
        {
            alumno = new Alumno();
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
            if (!string.IsNullOrWhiteSpace(txtDni.Text))
            {
                alumno = MapearPresentacionNegocio();
                gestionAlumnos.Alumno = alumno;

                int resultado = gestionAlumnos.Edit();
                if (resultado > 0)
                {
                    MessageBox.Show("Alumno editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAlumnos.DataSource = gestionAlumnos.GetAll();
                    btnClear_Click(sender, e);
                }
                else if (resultado == 0)
                    MessageBox.Show("No se realizaron cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error al editar, compruebe que el dni no esté repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Seleccione a un alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDni.Text))
            {
                alumno = MapearPresentacionNegocio();
                gestionAlumnos.Alumno = alumno;

                int resultado = gestionAlumnos.Insert();
                if (resultado > 0)
                {
                    MessageBox.Show("Alumno insertado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAlumnos.DataSource = gestionAlumnos.GetAll();
                    btnClear_Click(sender, e);
                }
                else if (resultado == -1)
                    MessageBox.Show("El DNI ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error al insertar alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese un dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {   
            if (!String.IsNullOrWhiteSpace(txtDni.Text))
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    int resultado = gestionAlumnos.Remove();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Alumno borrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAlumnos.DataSource = gestionAlumnos.GetAll();
                        btnClear_Click(sender, e);
                        dgvAlumnos.ClearSelection();
                    }
                    else
                        MessageBox.Show("Error al borrar al alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Ingrese un dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDni.Text = txtNombre.Text = txtApellidos.Text = txtTelefono.Text = txtPoblacion.Text = "";
            gestionAlumnos.Alumno = new Alumno();
            dgvAlumnos.ClearSelection();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDni.Text))
            {
                alumno = gestionAlumnos.GetById(txtDni.Text);
                if (alumno is not null)
                {
                    MapearNegocioPresentacion(alumno);
                }
                else
                    MessageBox.Show("No existe ese dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese un dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SeleccionarFilaAlumno(string dni)
        {
            foreach (DataGridViewRow row in dgvAlumnos.Rows)
            {
                if (row.Cells["Dni"].Value.ToString() == dni)
                {
                    dgvAlumnos.CurrentCell = row.Cells["Dni"];
                    break;
                }
            }
        }
    }
}