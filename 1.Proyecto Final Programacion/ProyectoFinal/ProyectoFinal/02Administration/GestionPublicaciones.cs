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
                dt.Rows[0]["descripcion"].ToString(), dt.Rows[0]["imagen"].ToString(), dt.Rows[0]["idperfil"].ToString());
            }
            return null;
        }
        public List<Publicacion> GetAll(string idperfil)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM publicacion WHERE idperfil = '{idperfil}' ORDER BY idperfil ASC");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                publicaciones.Add(new Publicacion(dt.Rows[i]["idpublicacion"].ToString(), dt.Rows[i]["titulo"].ToString(),
                dt.Rows[i]["descripcion"].ToString(), dt.Rows[i]["imagen"].ToString(), dt.Rows[i]["idperfil"].ToString()));
            return publicaciones;
        }
        public List<Publicacion> GetAllAll(string id)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();
            DataTable dt = BaseDatos.Consulta($"SELECT p.* FROM publicaciones p INNER JOIN perfil pf ON p.idperfil = pf.idperfil WHERE pf.idusuario = '{id}';");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                publicaciones.Add(new Publicacion(dt.Rows[i]["idpublicacion"].ToString(), dt.Rows[i]["titulo"].ToString(),
                dt.Rows[i]["descripcion"].ToString(), dt.Rows[i]["imagen"].ToString(), dt.Rows[i]["idperfil"].ToString()));
            return publicaciones;
        }
    }
}
