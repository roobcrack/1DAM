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
                MessageError(string.IsNullOrEmpty(message) ? "No hay más alumnos en la base de datos" : message);
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

            alumno = new Alumno()
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
            MapearNegocioPresentacion(gestionAlumnos.Primero());
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            MapearNegocioPresentacion(gestionAlumnos.Ultimo());
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MapearNegocioPresentacion(gestionAlumnos.Siguiente());
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MapearNegocioPresentacion(gestionAlumnos.Anterior());
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (alumno is not null)
            {
                gestionAlumnos.Alumno = MapearPresentacionNegocio();

                if (VerificarOperacion(gestionAlumnos.Edit()))
                {
                    dgvAlumnos.DataSource = gestionAlumnos.GetAll();
                    btnClear_Click(sender, e);
                }
            }
            else
                MessageError("Seleccione un alumno");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDni.Text))
            {
                gestionAlumnos.Alumno = MapearPresentacionNegocio();

                if(VerificarOperacion(gestionAlumnos.Insert()))
                {
                    dgvAlumnos.DataSource = gestionAlumnos.GetAll();
                    btnClear_Click(sender, e);
                }
            }
            else
                MessageError("Ingrese un dni");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {   
            if (!String.IsNullOrWhiteSpace(txtDni.Text))
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if(VerificarOperacion(gestionAlumnos.Remove()))
                    {
                        dgvAlumnos.DataSource = gestionAlumnos.GetAll();
                        btnClear_Click(sender, e);
                    }
                }
            }
            else
                MessageError("Ingrese un dni");
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDni.Text))
            {
                alumno = gestionAlumnos.GetById(txtDni.Text);
                if (alumno is not null)
                    MapearNegocioPresentacion(alumno);
                else
                    MessageError("No existe ese dni");
            }
            else
                MessageError("Ingrese un dni");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDni.Text = txtNombre.Text = txtApellidos.Text = txtTelefono.Text = txtPoblacion.Text = "";
            gestionAlumnos.Alumno = new Alumno();
            dgvAlumnos.ClearSelection();
        }
        private void SeleccionarFilaAlumno(string dni)
        {
            foreach (DataGridViewRow row in dgvAlumnos.Rows)
            {
                if (row.Cells["dni"].Value.ToString() == dni)
                {
                    dgvAlumnos.CurrentCell = row.Cells["dni"];
                    break;
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
                    MessageError("Error, compruebe que no haya fallos");
                    break;
            }
            return resultado > 0;
        }
    }
}
