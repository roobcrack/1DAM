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
            curso.Titulo = txtTitulo.Text;
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
            // Verificar si la columna clicada es válida y si el índice de la fila es válido
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvGestionCursos.Rows[e.RowIndex];

                // Crear un objeto Curso con los datos 0.
                // ................. .de la fila seleccionada
                Curso curso = new Curso()
                {
                    Codigo = Convert.ToString(selectedRow.Cells["codigo"].Value), // Ajusta el nombre de la columna según tu DataGridView
                    Titulo = Convert.ToString(selectedRow.Cells["titulo"].Value),
                    Num_plazas = Convert.ToString(selectedRow.Cells["num_plazas"].Value), // Ajusta el tipo de dato según corresponda
                    Precio = Convert.ToString(selectedRow.Cells["precio"].Value), // Ajusta el tipo de dato según corresponda
                    Lugar_realizacion = Convert.ToString(selectedRow.Cells["lugar_realizacion"].Value) // Ajusta el nombre de la columna según tu DataGridView
                };

                // Mapear los datos del curso seleccionado a los campos de presentación
                MapearNegocioPresentacion(curso);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Curso curso = gestionCursos.Primero();
            if (curso != null)
            {
                MapearNegocioPresentacion(curso);

                // Verificar si hay al menos una fila en el DataGridView
                if (dgvGestionCursos.Rows.Count > 0)
                {
                    dgvGestionCursos.Rows[0].Selected = true;
                }
            }
            else
            {
                // Manejar el caso en el que no se encuentre ningún curso
                MessageBox.Show("No se encontró ningún curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
