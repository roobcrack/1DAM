using ProyectoFinal._03Data;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal._02Administration
{
    internal class GestionUsuarios
    {
        public Usuario Usuario { get; set; }

        public Usuario GetByName(string nombre)
        {
            return GetBy("SELECT * FROM usuario WHERE nombre = '" + nombre + "'");
        }
        public Usuario GetById(string id)
        {
            return GetBy("SELECT * FROM usuario WHERE idusuario = '" + id + "'");
        }

        public Usuario GetBy(string sql)
        {
            DataTable dt = BaseDatos.Consulta(sql);
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
