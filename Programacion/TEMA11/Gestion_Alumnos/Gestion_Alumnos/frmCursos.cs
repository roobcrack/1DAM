using System;
using System.Windows.Forms;

namespace Gestion_Alumnos
{
    public partial class frmCursos : Form
    {
        private GestionCursos gestionCursos = new GestionCursos();

        public frmCursos()
        {
            InitializeComponent();
        }

        public void MapearNegocioPresentacion(Curso curso)
        {
            txtCodigo.Text = curso.Codigo;
            txtTitulo.Text = curso.Titulo;
            txtNumeroPlazas.Text = curso.Num_plazas;
            txtPrecio.Text = curso.Precio;
            txtLugarRealizacion.Text = curso.Lugar_realizacion;
        }

        // Método para mapear datos de los textBox al objeto Alumno
        public Curso MapearPresentacionNegocio()
        {
            Curso curso = new Curso();
            curso.Codigo = txtCodigo.Text;
            curso.Titulo= txtTitulo.Text;
            curso.Num_plazas = txtNumeroPlazas.Text;
            curso.Precio = txtPrecio.Text;
            curso.Lugar_realizacion = txtLugarRealizacion.Text;

            return curso;
        }
        private void frmCursos_Load(object sender, EventArgs e)
        {
            dgvGestionCursos.DataSource = gestionCursos.GetAll();
        }

        private void dgvGestionCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            if (e.ColumnIndex >= 0 && e.RowIndex < dgvGestionCursos.Rows.Count)
            {
                // Obtener el alumno seleccionado en el DataGridView
                DataGridViewRow selectedRow = dgvGestionCursos.Rows[e.RowIndex];

                // Declarar el alumno a mapear
                Curso curso = new Curso()
                {
                    Codigo = Convert.ToString(selectedRow.Cells["Codigo"].Value),
                    Titulo = Convert.ToString(selectedRow.Cells["Titulo"].Value),
                    Num_plazas = Convert.ToString(selectedRow.Cells["Num_plazas"].Value),
                    Precio = Convert.ToString(selectedRow.Cells["Precio"].Value),
                    Lugar_realizacion = Convert.ToString(selectedRow.Cells["Lugar_realizacion"].Value)
                };

                // Cargamos el alumno a la clase de gestión
                //dgvGestionCursos.Curso = curso;

                // Mapear los datos del alumno seleccionado a los campos de texto
                MapearNegocioPresentacion(curso);
            }
        }
    }
}
