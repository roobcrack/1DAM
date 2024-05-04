using Org.BouncyCastle.Asn1.Cmp;
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
                MessageError(string.IsNullOrEmpty(message) ? "No hay más cursos en la base de datos" : message);
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
            MapearNegocioPresentacion(gestionCursos.Primero());
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            MapearNegocioPresentacion(gestionCursos.Ultimo());
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MapearNegocioPresentacion(gestionCursos.Siguiente());
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MapearNegocioPresentacion(gestionCursos.Anterior());
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (curso is not null)
            {
                gestionCursos.Curso = MapearPresentacionNegocio();

                if (VerificarOperacion(gestionCursos.Edit()))
                {
                    dgvGestionCursos.DataSource = gestionCursos.GetAll();
                    btnClear_Click(sender, e);
                }
            }
            else
                MessageError("Seleccione un curso");
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (curso is not null)
            {
                DialogResult opcion = MessageBox.Show("¿Estás seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    if(VerificarOperacion(gestionCursos.Remove()))
                    {
                        dgvGestionCursos.DataSource = gestionCursos.GetAll();
                        btnClear_Click(sender, e);                    
                    }
                }
            }
            else
                MessageError("Seleccione un curso");
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                curso = gestionCursos.GetById(txtCodigo.Text);
                if (curso is not null)
                    MapearNegocioPresentacion(curso);
                else
                    MessageError("No existe ese codigo");
            }
            else
                MessageError("Ingrese un codigo");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtTitulo.Text = txtNumeroPlazas.Text = txtPrecio.Text = txtLugarRealizacion.Text = "";
            gestionCursos.Curso = new Curso();
            dgvGestionCursos.ClearSelection();
        }
        private void SeleccionarFilaCurso(string codigo)
        {
            foreach (DataGridViewRow row in dgvGestionCursos.Rows)
            {
                if (row.Cells["Codigo"].Value.ToString() == codigo)
                {
                    dgvGestionCursos.CurrentCell = row.Cells["Codigo"];
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
                case 1: MessageBox.Show("Se ha realizado correctamente", "Correcto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0: MessageError("No se realizaron cambios");
                    break;
                default: MessageError("Error, compruebe que no haya fallos");
                    break;
            }
            return resultado > 0;
        }
    }
}
