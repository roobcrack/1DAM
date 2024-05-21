using ProyectoFinal._03Data;
using System.Data;

namespace ProyectoFinal._02Administration
{
    internal class GestionUsuarios
    {
        public Usuario Usuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
        private GestionPublicaciones gp = new GestionPublicaciones();

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
                return BaseDatos.Modificacion($"INSERT INTO usuario (idusuario, nombre, contraseña, rol) VALUES ('{Usuario.IdUsuario}'," +
                    $" '{Usuario.Nombre}', '{Usuario.Contraseña}', '{Usuario.Rol}')");
        }
        public int ActualizarId()
        {
            List<Usuario> usr = GetAll();
            int newId = 1;
            foreach (Usuario u in usr)
            {
                int consulta = BaseDatos.Modificacion($"UPDATE usuario SET idusuario = '{newId++}' WHERE idusuario = '{u.IdUsuario}'");
                if (consulta <= 0)
                    return consulta;
            }
            return 1;
        }
        public int Eliminar()
        {
            return BaseDatos.Modificacion($"DELETE FROM usuario WHERE idusuario = " + Usuario.IdUsuario);

        }
        public void Filtrar(bool usuario,bool admin, string nombre)
        {
            if(Usuario is not null)
            {
                Usuarios = GetAll();
                for (int i = 0; i < Usuarios.Count; i++)
                {
                    if ((usuario && gp.GetAllFromUser(Usuarios[i].IdUsuario).Count <= 0) || 
                        (!string.IsNullOrWhiteSpace(nombre) && !Usuarios[i].Nombre.StartsWith(nombre)) ||
                        (admin && Usuarios[i].Rol == "administrador"))
                        Usuarios.RemoveAt(i--);
                }
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
