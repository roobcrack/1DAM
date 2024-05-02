using academia_03data;
using System.Data;
using System.Net;

class GestionCursos
{
    public Curso Curso { get; set; }
    public GestionCursos()
    {
        Curso = new Curso();
    }

    public string Error()
    {
        return BaseDatos.Error;
    }
    public Curso Primero()
    {
        return GetOneBySql($"SELECT * FROM cursos ORDER BY codigo ASC LIMIT 1");
    }
    public Curso Ultimo()
    {
        return GetOneBySql($"SELECT * FROM cursos ORDER BY codigo DESC LIMIT 1");
    }
    public Curso Siguiente()
    {
        return GetOneBySql($"SELECT * FROM cursos WHERE codigo > '" + this.Curso.Codigo + "' ORDER BY codigo ASC LIMIT 1");
    }
    public Curso Anterior()
    {
        return GetOneBySql($"SELECT * FROM cursos WHERE codigo < '" + this.Curso.Codigo + "' ORDER BY codigo DESC LIMIT 1");
    }
    public int Edit()
    {
        string sql = $"SELECT * FROM cursos WHERE codigo = '{this.Curso.Codigo}'";
        DataTable consulta = BaseDatos.Consulta(sql);

        if (consulta != null && consulta.Rows.Count > 0)
        {
            sql = $"UPDATE cursos SET titulo = '{this.Curso.Titulo}', n_plazas = '{this.Curso.Num_plazas}', " +
                $"precio = '{this.Curso.Precio}', lugar_realizacion = '{this.Curso.Lugar_realizacion}' WHERE codigo = '{this.Curso.Codigo}'";
            return BaseDatos.Modificacion(sql);
        }
        return -1;
    }
    public int Remove()
    {
        return BaseDatos.Modificacion($"DELETE FROM cursos WHERE codigo = '" + Curso.Codigo + "'");
    }
    public Curso GetById(string codigo)
    {
        DataTable dt = BaseDatos.Consulta($"select * from cursos where codigo = '" + codigo + "'");
        if(dt != null && dt.Rows.Count > 0)
        {
            Curso c = new Curso(dt.Rows[0]["codigo"].ToString(), dt.Rows[0]["titulo"].ToString(),
                dt.Rows[0]["n_plazas"].ToString(), dt.Rows[0]["precio"].ToString(), 
                dt.Rows[0]["lugar_realizacion"].ToString());
            return c;
        }
        return null;
    }
    public List<Curso> GetAll()
    {
        List<Curso> cursos = new List<Curso>();
        DataTable dt = BaseDatos.Consulta("select * from cursos order by codigo");
        for (int i = 0; dt != null && i < dt.Rows.Count; i++)
        {
            cursos.Add(new Curso(dt.Rows[i]["codigo"].ToString(), dt.Rows[i]["titulo"].ToString(),
            dt.Rows[i]["n_plazas"].ToString(), dt.Rows[i]["precio"].ToString(), dt.Rows[i]
            ["lugar_realizacion"].ToString()));
        }
        return cursos;
    }
    public Curso GetOneBySql(string sql)
    {
        DataTable dt = BaseDatos.Consulta(sql);
        if (dt != null && dt.Rows.Count > 0)
        {
            Curso c = new Curso(dt.Rows[0]["codigo"].ToString(), dt.Rows[0]["titulo"].ToString(),
            dt.Rows[0]["n_plazas"].ToString(), dt.Rows[0]["precio"].ToString(), dt.Rows[0]
            ["lugar_realizacion"].ToString());
            return c;
        }
        return null;
    }
}