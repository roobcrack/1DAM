namespace Gestion_Alumnos
{
    public class Matricula
    {
        public string Dni { get; set; }
        public string Codigo { get; set; }

        public Matricula(string dni, string codigo)
        {
            Dni = dni;
            Codigo = codigo;
        }
        public Matricula() { }
    }
}
