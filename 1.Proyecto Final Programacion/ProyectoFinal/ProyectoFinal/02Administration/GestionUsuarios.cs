using ProyectoFinal._03Data;
using System.Data;

namespace ProyectoFinal._02Administration
{
    internal class GestionUsuarios
    {
        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public GestionUsuarios()
        {
            Usuarios = GetAll();
        }
        public Usuario GetByName(string nombre)
        {
            return GetBySql("SELECT * FROM usuario WHERE nombre = '" + nombre + "'");
        }

        public int RegistrarUsuario()
        {
            if (GetByName(Usuario.Nombre) is null)
                return BaseDatos.Modificacion($"INSERT INTO usuario (idusuario, nombre, contraseña, rol) VALUES ('{Usuario.IdUsuario}'," +
                    $" '{Usuario.Nombre}', '{Usuario.Contraseña}', '{Usuario.Rol}')");
            return -1;
        }
        public int ActualizarId()
        {
            List<Usuario> usuarios = GetAll();
            for(int i=0; i<usuarios.Count; i++)
            {
                int newId = i + 1;
                return BaseDatos.Modificacion($"UPDATE usuario SET idusuario = '{newId}' WHERE idusuario = '{usuarios[i].IdUsuario}'");
            }
            return -1;
        }
        public void Filtrar(bool usuario, string nombre)
        {
            Usuarios = GetAll();
            for(int i=0; i< Usuarios.Count; i++)
            {
                if ((usuario && Usuarios[i].Rol == "usuario") ||
                    (!string.IsNullOrWhiteSpace(nombre) && !Usuarios[i].Nombre.StartsWith(nombre)))
                    Usuarios.RemoveAt(i--);
            }
        }






        public Usuario GetBySql(string sql)
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
            DataTable dt = BaseDatos.Consulta("SELECT * FROM usuario ORDER BY idusuario ASC");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                usuarios.Add(new Usuario(dt.Rows[i]["idusuario"].ToString(), dt.Rows[i]["nombre"].ToString(),
                dt.Rows[i]["contraseña"].ToString(), dt.Rows[i]["rol"].ToString()));
            return usuarios;
        }
    }
}
