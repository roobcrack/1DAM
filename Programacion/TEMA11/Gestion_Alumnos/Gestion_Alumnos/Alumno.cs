using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alumno
{
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Telefono { get; set; }
    public string Poblacion { get; set; }

    public Alumno(string dni, string nombre, string apellidos, string telefono, string poblacion)
    {
        Dni = dni;
        Nombre = nombre;
        Apellidos = apellidos;
        Telefono = telefono;
        Poblacion = poblacion;
    }
    public Alumno() { }
}
