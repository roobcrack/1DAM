using System;

namespace Libro
{
    internal class Articulo : Documento
    {

        protected string procedencia {  get; set; }
        public string GetProcedencia() { return procedencia; }

        public Articulo(string autor, string titulo, string ubicacion, string procedencia)
            :base(autor, titulo, ubicacion)
        {
            this.procedencia = procedencia;
        }
        public override bool Contiene(string textoBuscar)
        {
            return base.Contiene(textoBuscar) || this.procedencia.Contains(textoBuscar);
        }
        public override string ToString()
        {
            return base.ToString() + " | Procedencia: " + this.procedencia;
        }
    }
}
