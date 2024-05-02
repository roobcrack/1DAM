using System;
using System.Windows.Forms;

namespace Gestion_Alumnos
{
    public partial class frmCursos : Form
    {
        private GestionCursos gestionCursos = new GestionCursos();
        private Curso curso;

        public frmCursos()
        {
            InitializeComponent();
        }
        private void frmCursos_Load_1(object sender, EventArgs e)
        {
            dgvGestionCursos.DataSource = gestionCursos.GetAll();
        }
        public void MapearNegocioPresentacion(Curso curso)
        {
            if (curso != null)
            {
                txtCodigo.Text = curso.Codigo;
                txtTitulo.Text = curso.Titulo;
                txtNumeroPlazas.Text = curso.Num_plazas;
                txtPrecio.Text = curso.Precio;
                txtLugarRealizacion.Text = curso.Lugar_realizacion;
                gestionCursos.Curso = curso;
                SeleccionarFilaCurso(curso.Codigo);
            }
            else
            {
                string message = gestionCursos.Error();
                MessageBox.Show(string.IsNullOrEmpty(message) ? "No hay más cursos en la base de datos" :
                    message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Curso MapearPresentacionNegocio()
        {
            curso = new Curso();
            curso.Codigo = txtCodigo.Text;
            curso.Titulo = txtTitulo.Text;
            curso.Num_plazas = txtNumeroPlazas.Text;
            curso.Precio = txtPrecio.Text;
            curso.Lugar_realizacion = txtLugarRealizacion.Text;

            return curso;
        }
        private void dgvGestionCursos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvGestionCursos.Rows[e.RowIndex];

            curso = new Curso()
            {
                Codigo = Convert.ToString(selectedRow.Cells["codigo"].Value),
                Titulo = Convert.ToString(selectedRow.Cells["titulo"].Value),
                Num_plazas = Convert.ToString(selectedRow.Cells["num_plazas"].Value),
                Precio = Convert.ToString(selectedRow.Cells["precio"].Value),
                Lugar_realizacion = Convert.ToString(selectedRow.Cells["lugar_realizacion"].Value)
            };

            MapearNegocioPresentacion(curso);
        }

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            curso = gestionCursos.Primero();
            MapearNegocioPresentacion(curso);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            curso = gestionCursos.Ultimo();
            MapearNegocioPresentacion(curso);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            curso = gestionCursos.Siguiente();
            MapearNegocioPresentacion(curso);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            curso = gestionCursos.Anterior();
            MapearNegocioPresentacion(curso);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                curso = MapearPresentacionNegocio();
                gestionCursos.Curso = curso;

                int resultado = gestionCursos.Edit();
                if (resultado > 0)
                {
                    MessageBox.Show("Curso editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGestionCursos.DataSource = gestionCursos.GetAll();
                    btnClear_Click(sender, e);
                }
                else if (resultado == 0)
                    MessageBox.Show("No se realizaron cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error al editar, compruebe que el codigo no esté repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Seleccione un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    int resultado = gestionCursos.Remove();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Curso borrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGestionCursos.DataSource = gestionCursos.GetAll();
                        btnClear_Click(sender, e);
                        dgvGestionCursos.ClearSelection();
                    }
                    else
                        MessageBox.Show("Error al borrar el curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Ingrese un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                curso = gestionCursos.GetById(txtCodigo.Text);
                if (curso is not null)
                {
                    MapearNegocioPresentacion(curso);
                }
                else
                    MessageBox.Show("No existe ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtTitulo.Text = txtNumeroPlazas.Text = txtPrecio.Text = txtLugarRealizacion.Text = "";
            gestionCursos.Curso = new Curso();
            dgvGestionCursos.ClearSelection();
        }

        private void SeleccionarFilaCurso(string dni)
        {
            foreach (DataGridViewRow row in dgvGestionCursos.Rows)
            {
                if (row.Cells["Codigo"].Value.ToString() == dni)
                {
                    dgvGestionCursos.CurrentCell = row.Cells["Codigo"];
                    break;
                }
            }
        }
    }
}
