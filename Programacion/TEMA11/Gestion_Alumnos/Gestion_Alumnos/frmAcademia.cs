using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Alumnos
{
    public partial class frmAcademia : Form
    {
        public frmAcademia()
        {
            InitializeComponent();
        }

        private void btMantenimientoAlumnos_Click(object sender, EventArgs e)
        {
            Form frmAlumnos = new frmAlumnos();
            frmAlumnos.Show();
        }

        private void btMantenimientoCursos_Click(object sender, EventArgs e)
        {
            Form frmCursos = new frmCursos();
            frmCursos.Show();
        }

        private void btMatriculacion_Click(object sender, EventArgs e)
        {

        }
    }
}
