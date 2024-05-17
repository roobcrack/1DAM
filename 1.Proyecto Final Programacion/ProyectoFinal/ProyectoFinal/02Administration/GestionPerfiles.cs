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
        public int Remove(string idperfil)
        {
            return BaseDatos.Modificacion($"DELETE FROM perfil WHERE idperfil = '" + idperfil + "'");
        }
        public int Insert(string idusuario)
        {
            frmCrearPerfil frmCrearPerfil = new frmCrearPerfil(idusuario);
            frmCrearPerfil.Show();
            Perfil = frmCrearPerfil.Perfil;

            if (Perfil.IdPerfil is not null)
                return BaseDatos.Modificacion($"INSERT INTO perfil (idperfil, nombreperfil, resumen, idusuario) VALUES ('{Perfil.IdPerfil}'," +
                $" '{Perfil.NombrePerfil}', '{Perfil.Resumen}', '{Perfil.IdUsuario}')");
            return -1;
        }
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
    }
}