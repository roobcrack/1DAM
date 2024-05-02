using academia_03data;
using System.Data;

class GestionAlumnos
{
    public Alumno Alumno { set; get; }
    public GestionAlumnos()
    {
        Alumno = new Alumno();
    }

    public string Error()
    {
        return BaseDatos.Error;
    }
    public Alumno Primero()
    {
        return GetOneBySql($"SELECT * FROM alumnos ORDER BY dni ASC LIMIT 1");
    }
    public Alumno Ultimo()
    {
        return GetOneBySql($"SELECT * FROM alumnos ORDER BY dni DESC LIMIT 1");
    }
    public Alumno Siguiente()
    {
        return GetOneBySql($"SELECT * FROM alumnos WHERE dni > '"+this.Alumno.Dni+"' ORDER BY dni ASC LIMIT 1");
    }
    public Alumno Anterior()
    {
        return GetOneBySql($"SELECT * FROM alumnos WHERE dni < '"+this.Alumno.Dni+"' ORDER BY dni DESC LIMIT 1");
    }

    public int Edit()
    {
        string sql = $"SELECT * FROM alumnos WHERE dni = '{this.Alumno.Dni}'";
        DataTable consulta = BaseDatos.Consulta(sql);

        if (consulta != null && consulta.Rows.Count > 0)
        {
            sql = $"UPDATE alumnos SET nombre = '{this.Alumno.Nombre}', apellidos = '{this.Alumno.Apellidos}', " +
                $"telefono = '{this.Alumno.Telefono}', poblacion = '{this.Alumno.Poblacion}' WHERE dni = '{this.Alumno.Dni}'";
            return BaseDatos.Modificacion(sql);
        }
        return -1;
    }
    public int Insert()
    {
        DataTable consulta = BaseDatos.Consulta($"SELECT COUNT(*) FROM alumnos WHERE dni = '"+this.Alumno.Dni+"'");

        if (consulta != null && consulta.Rows.Count > 0 && Convert.ToInt32(consulta.Rows[0][0]) > 0)
            return -1;

        return BaseDatos.Modificacion($"INSERT INTO alumnos (dni, nombre, apellidos, poblacion, telefono) VALUES " +
                     "('" + this.Alumno.Dni + "', '" + this.Alumno.Nombre + "', '" + this.Alumno.Apellidos + "', " +
                     "'" + this.Alumno.Poblacion + "', '" + this.Alumno.Telefono + "')");
    }
    public int Remove()
    {        
        return BaseDatos.Modificacion($"DELETE FROM alumnos WHERE dni = '" + Alumno.Dni + "'");
    }

    public Alumno GetById(string dni)
    {
        DataTable dt = BaseDatos.Consulta("select * from alumnos where dni = '" + dni + "'");
        if (dt != null && dt.Rows.Count > 0)
        {
            Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
                dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(), 
                dt.Rows[0]["poblacion"].ToString());
            return a;
        }
        return null;
    }
    public List<Alumno> GetAll()
    {
        List<Alumno> alumnos = new List<Alumno>();
        DataTable dt = BaseDatos.Consulta("select * from alumnos order by dni");
        for (int i = 0; dt != null && i < dt.Rows.Count; i++)
        {
            alumnos.Add(new Alumno(dt.Rows[i]["dni"].ToString(), dt.Rows[i]["nombre"].ToString(),
            dt.Rows[i]["apellidos"].ToString(), dt.Rows[i]["telefono"].ToString(), dt.Rows[i]
            ["poblacion"].ToString()));
        }
        return alumnos;
    }
    public Alumno GetOneBySql(string sql)
    {
        DataTable dt = BaseDatos.Consulta(sql);
        if (dt != null && dt.Rows.Count > 0)
        {
            Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
            dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(), dt.Rows[0]
            ["poblacion"].ToString());
            return a;
        }
        return null;
    }
}