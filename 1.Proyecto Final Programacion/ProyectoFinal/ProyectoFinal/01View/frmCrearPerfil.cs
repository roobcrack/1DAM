using ProyectoFinal._02Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal._01View
{
    public partial class frmCrearPerfil : Form
    {
        private string idusuario;
        private GestionPerfiles gp = new GestionPerfiles();
        public Perfil Perfil { get; set; }
        public frmCrearPerfil(string idusuario)
        {
            InitializeComponent();
            this.idusuario = idusuario;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Perfil = new Perfil(Convert.ToString(gp.GetAllAll().Count + 1), txtNombre.Text, txtResumen.Text, this.idusuario);
            this.Close();
        }
    }
}
