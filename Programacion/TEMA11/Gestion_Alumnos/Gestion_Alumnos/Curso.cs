using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Curso
{
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string Num_plazas { get; set; }
    public string Precio { get; set; }
    public string Lugar_realizacion { get; set; }

    public Curso(string codigo, string titulo, string num_plazas, string precio, string lugar_realizacion)
    {
        Codigo = codigo;
        Titulo = titulo;
        Num_plazas = num_plazas;
        Precio = precio;
        Lugar_realizacion = lugar_realizacion;
    }
    public Curso() { }
}
