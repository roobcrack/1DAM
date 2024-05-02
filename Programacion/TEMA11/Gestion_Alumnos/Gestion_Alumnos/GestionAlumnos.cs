using academia_03data;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Math;
using System.Data;
using System.Net;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
        if (Alumno == null)
            return null;

        return GetOneBySql($"SELECT * FROM alumnos WHERE dni > '{Alumno.Dni}' ORDER BY dni ASC LIMIT 1");
    }
    public Alumno Anterior()
    {
        if (Alumno == null)
            return null;

        return GetOneBySql($"SELECT * FROM alumnos WHERE dni < '{Alumno.Dni}' ORDER BY dni DESC LIMIT 1");
    }

    public int Edit()
    {
        string sql = $"SELECT * FROM alumnos WHERE dni = '" + this.Alumno.Dni + "'";
        if (BaseDatos.Consulta(sql).Rows.Count > 0)
        {
            sql = $"UPDATE alumnos SET nombre = '" + this.Alumno.Nombre + "', apellidos = '"
                + this.Alumno.Apellidos + "', telefono = '" + this.Alumno.Telefono +
                "', poblacion = '" + this.Alumno.Poblacion + "' WHERE dni = '" + this.Alumno.Dni +
                "'";
            return BaseDatos.Modificacion(sql);
        }
        return -1;
    }
    //Este método inserta un nuevo alumno cuyos datos tenemos cargados en la propiedad Alumno, para ello
    //primero mira que el alumno no exista en la base de datos, en caso de que ya exista devuelve -1
    public int Insert()
    {
        //Este método hace intenta insertar el alumno que tenemos en la propiedad
        //GestionAlumnos.Alumno:
        //-si no existe su DNI en la base de datos lo inserta y devuelve 1
        //- Si existe su DNI o hay algún error devuelve -1
        return 0;
    }
    public int Remove()
    {
        //Este método borra de la base de la base de datos el alumno con la clave principal:
        //Alumno.dni.Habrá que sacar una ventana de advertencia antes de borrarlo
        return 0;
    }
    //Este método obtiene el alumno cuyo dni se pasa como parámetro
    public Alumno GetById(string dni)
    {
        DataTable dt = BaseDatos.Consulta("select * from alumnos where dni = '" + dni + "'");
        if (dt != null && dt.Rows.Count > 0)
        {
            Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
                dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(), dt.Rows[0]
                ["poblacion"].ToString());
            return (a);
        }
        return null;
    }
    //Este método obtiene una lista con todos los alumnos
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
    //Este método obtiene un alumno (el primero en orden) a partir de una consulta SQL
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