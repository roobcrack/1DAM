using ProyectoFinal._01View;
using ProyectoFinal._03Data;
using System.Data;

namespace ProyectoFinal._02Administration
{
    internal class GestionPerfiles
    {
        public Perfil Perfil { get; set; }
        public List<Perfil> Perfiles { get; set;  }

        public GestionPerfiles()
        {
            Perfiles = GetAll("");
        }
        public Perfil GetById(string idperfil)
        {
            return GetBySql("SELECT * FROM perfil WHERE idperfil = '" + idperfil + "'");
        }
        public void Filtrar(bool filtrado, string idusuario, GestionPublicaciones gpu)
        {
            Perfiles = GetAll(idusuario);
            if (filtrado)
            {
                for(int i=0; i<Perfiles.Count; i++)
                {
                    if (gpu.GetAll(Perfiles[i].IdPerfil).Count <= 0)
                        Perfiles.RemoveAt(i--);
                }
            }
        }
<<<<<<< HEAD
=======
        public int Insertar()
        {
            return BaseDatos.Modificacion($"INSERT INTO perfil (idperfil, nombreperfil, resumen, idusuario) VALUES " +
                         $"('" + Perfil.IdPerfil + "', '" + Perfil.NombrePerfil + "', '" + Perfil.Resumen + "', " +
                         $"'" + Perfil.IdUsuario + "')");
        }
        public int Eliminar()
        {
            return BaseDatos.Modificacion($"DELETE FROM perfil WHERE idperfil = " + Perfil.IdPerfil);
        }
        public int ActualizarId()
        {
            List<Perfil> perf = GetAllAll();
            int newId = 1;
            foreach (Perfil p in perf)
            {
                int consulta = BaseDatos.Modificacion($"UPDATE perfil SET idperfil = '{newId++}' WHERE idperfil = '{p.IdPerfil}'");
                if (consulta <= 0)
                    return consulta;
            }
            return 1;
        }
>>>>>>> 6a438c72b589b2014346472eb204dfa363964284
        public Perfil GetBySql(string sql)
        {
            DataTable dt = BaseDatos.Consulta(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return new Perfil(dt.Rows[0]["idperfil"].ToString(), dt.Rows[0]["nombreperfil"].ToString(),
                dt.Rows[0]["resumen"].ToString(), dt.Rows[0]["idusuario"].ToString());
            }
            return null;
        }
        public List<Perfil> GetAll(string id)
        {
            List<Perfil> perfiles = new List<Perfil>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM perfil WHERE idusuario = '{id}'");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                perfiles.Add(new Perfil(dt.Rows[i]["idperfil"].ToString(), dt.Rows[i]["nombreperfil"].ToString(),
                dt.Rows[i]["resumen"].ToString(), dt.Rows[i]["idusuario"].ToString()));
            return perfiles;
        }
        public List<Perfil> GetAllAll()
        {
            List<Perfil> perfiles = new List<Perfil>();
            DataTable dt = BaseDatos.Consulta($"SELECT * FROM perfil");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
                perfiles.Add(new Perfil(dt.Rows[i]["idperfil"].ToString(), dt.Rows[i]["nombreperfil"].ToString(),
                dt.Rows[i]["resumen"].ToString(), dt.Rows[i]["idusuario"].ToString()));
            return perfiles;
        }
    }
}