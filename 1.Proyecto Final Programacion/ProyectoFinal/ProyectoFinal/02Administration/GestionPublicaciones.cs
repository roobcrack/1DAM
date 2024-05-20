using ProyectoFinal._03Data;
using System.Data;

namespace ProyectoFinal._02Administration
{
    internal class GestionPublicaciones
    {
        public Publicacion Publicacion;
        public List<Publicacion> Publicaciones;
        public GestionPublicaciones()
        {
            Publicaciones = GetAll("");
        }
        public Publicacion GetById(string sql)
        {
            DataTable dt = BaseDatos.Consulta(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return new Publicacion(dt.Rows[0]["idpublicacion"].ToString(), dt.Rows[0]["titulo"].ToString(),
                dt.Rows[0]["descripcion"].ToString(), dt.Rows[0]["imagenruta"].ToString(), dt.Rows[0]["idperfil"].ToString());
            }
            return null;
        }
        public string Error()
        {
            return BaseDatos.Error;
        }
        public int Insertar()
        {
            return BaseDatos.Modificacion($"INSERT INTO publicacion (idpublicacion, titulo, descripcion, imagenruta, idperfil) VALUES " +
                         $"('" + Publicacion.IdPublicacion + "', '" + Publicacion.Titulo + "', '" + Publicacion.Descripcion + "', " +
                         $"'" + Publicacion.ImagenRuta + "', '" + Publicacion.IdPerfil + "')");
        }
        public int Modificar()
        {
            DataTable consulta = BaseDatos.Consulta($"SELECT * FROM publicacion WHERE idpublicacion = '{Publicacion.IdPublicacion}'");

            if (consulta != null && consulta.Rows.Count > 0)
            {
                return BaseDatos.Modificacion($"UPDATE publicacion SET titulo = '{Publicacion.Titulo}', " +
                    $"descripcion = '{Publicacion.Descripcion}', imagenruta = '{Publicacion.ImagenRuta}' WHERE idpublicacion = '{Publicacion.IdPublicacion}'");
            }
            return -1;
        }
        public int Eliminar()
        {
            return BaseDatos.Modificacion($"DELETE FROM publicacion WHERE idpublicacion = " + Publicacion.IdPublicacion);
        }
        public int ActualizarId()
        {
            List<Publicacion> publi = GetAllAll();
            int newId = 1;
            foreach (Publicacion p in publi)
            {
                int consulta = BaseDatos.Modificacion($"UPDATE publicacion SET idpublicacion = '{newId++}' WHERE idpublicacion = '{p.IdPublicacion}'");
                if (consulta <= 0)
                    return consulta;
            }
            return 1;
        }
        public List<Publicacion> GetAll(string idperfil)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM publicacion WHERE idperfil = '{idperfil}'");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                publicaciones.Add(new Publicacion(dt.Rows[i]["idpublicacion"].ToString(), dt.Rows[i]["titulo"].ToString(),
                dt.Rows[i]["descripcion"].ToString(), dt.Rows[i]["imagenruta"].ToString(), dt.Rows[i]["idperfil"].ToString()));
            return publicaciones;
        }
        public List<Publicacion> GetAllFromUser(string id)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            DataTable dt = BaseDatos.Consulta($"SELECT p.* FROM publicacion p INNER JOIN perfil pf ON p.idperfil = pf.idperfil WHERE pf.idusuario = '{id}';");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                publicaciones.Add(new Publicacion(dt.Rows[i]["idpublicacion"].ToString(), dt.Rows[i]["titulo"].ToString(),
                dt.Rows[i]["descripcion"].ToString(), dt.Rows[i]["imagenruta"].ToString(), dt.Rows[i]["idperfil"].ToString()));
            return publicaciones;
        }
        public List<Publicacion> GetAllAll()
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM publicacion");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                publicaciones.Add(new Publicacion(dt.Rows[i]["idpublicacion"].ToString(), dt.Rows[i]["titulo"].ToString(),
                dt.Rows[i]["descripcion"].ToString(), dt.Rows[i]["imagenruta"].ToString(), dt.Rows[i]["idperfil"].ToString()));
            return publicaciones;
        }
    }
}
