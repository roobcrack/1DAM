﻿using academia_03data;
using System.Data;
using System.Net;

class GestionCursos
{
    public Curso Curso { get; set; }
    public GestionCursos()
    {
        Curso = new Curso();
    }
    // Muestere el error al cargar la base de datos
    public string Error()
    {
        return BaseDatos.Error;
    }
    /*
    // Selecciona el primer curso de la base de datos
    public Curso Primero()
    {
        string sql = "SELECT * FROM cursos ORDERED BY codigo ASC LIMIT 1"
        return 
    }
    // Selecciona el ultimo curso
    public Curso Ultimo()
    {

    }
    // Selecciona el siguiente curso al seleccionado
    public Curso Siguiente()
    {

    }
    // Selecciona el anterior curso al seleccionado
    public Curso Anterior()
    {

    }
    */
    public Curso GeyById(string codigo)
    {
        DataTable dt = BaseDatos.Consulta("select * from cursos where codigo = '" + codigo + "'");
        if(dt != null)
        {
            Curso a = new Curso(dt.Rows[0]["codigo"].ToString(), dt.Rows[0]["titulo"].ToString(),
                dt.Rows[0]["n_plazas"].ToString(), dt.Rows[0]["precio"].ToString(), 
                dt.Rows[0]["lugar_realizacion"].ToString());
            return a;
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