using System;

namespace Libro
{
    internal class Documento
    {
        protected string autor { get; set; }
        protected string titulo { get; set; }
        protected string ubicacion { get; set; }
        public Documento(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }
        public virtual void Mostrar()
        {
            Console.Write("\nAutor: {0} | Titulo: {1} | Ubicacion: {2}", this.autor, this.titulo, this.ubicacion);
        }
    }
}
