using ProyectoFinal._01View;
using ProyectoFinal._03Data;
using System.Data;

namespace ProyectoFinal._02Administration
{
    public class GestionComentarios
    {
        public Comentario Comentario { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public GestionComentarios()
        {
            Comentarios = GetAll("");
        }
        public int Comentar()
        {
            return BaseDatos.Modificacion($"INSERT INTO comentario (idcomentario, contenido, idpublicacion) VALUES " +
                         $"('" + Comentario.IdComentario + "', '" + Comentario.Contenido + "', '" + Comentario.IdPublicacion + "')");
        }


        public List<Comentario> GetAll(string id)
        {
            List<Comentario> comentarios = new List<Comentario>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM comentario WHERE idpublicacion = '{id}'");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                comentarios.Add(new Comentario(dt.Rows[i]["idcomentario"].ToString(), dt.Rows[i]["contenido"].ToString(),
                dt.Rows[i]["idpublicacion"].ToString()));
            return comentarios;
        }
        public List<Comentario> GetAllAll()
        {
            List<Comentario> comentarios = new List<Comentario>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM comentario");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                comentarios.Add(new Comentario(dt.Rows[i]["idcomentario"].ToString(), dt.Rows[i]["contenido"].ToString(),
                dt.Rows[i]["idpublicacion"].ToString()));
            return comentarios;
        }
    }
}
