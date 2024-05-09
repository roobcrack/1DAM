using ProyectoFinal._03Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal._02Administration
{
    internal class GestionUsuarios
    {
        public Usuario Usuario { get; set; }


        public Usuario GetByName(string nombre)
        {
            DataTable dt = BaseDatos.Consulta("select * from usuario where nombre = '" + nombre + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                return new Usuario(dt.Rows[0]["idusuario"].ToString(), dt.Rows[0]["nombre"].ToString(),
                dt.Rows[0]["contraseña"].ToString(), dt.Rows[0]["rol"].ToString());
            }
            return null;
        }
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            DataTable dt = BaseDatos.Consulta("select * from usuario order by idusuario");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                usuarios.Add(new Usuario(dt.Rows[i]["idusuario"].ToString(), dt.Rows[i]["nombre"].ToString(),
                dt.Rows[i]["contraseña"].ToString(), dt.Rows[i]["rol"].ToString()));
            }
            return usuarios;
        }
    }
}
