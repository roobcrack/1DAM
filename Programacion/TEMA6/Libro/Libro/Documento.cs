using System;

namespace Libro
{
    abstract internal class Documento
    {
        protected string? autor { get; set; }
        protected string? titulo { get; set; }
        protected string? ubicacion { get; set; }

        public Documento() { }
        public Documento(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }
        public virtual void RellenarDocumento()
        {
            Console.Write("Introduce el nombre del autor: ");
            this.autor = Console.ReadLine();
            Console.Write("Introduce el titulo: ");
            this.titulo = Console.ReadLine();
            Console.Write("Introduce la ubicacion: ");
            this.ubicacion = Console.ReadLine();
        }
        public virtual bool Contiene(string textoBuscar)
        {
            return this.autor.Contains(textoBuscar) || this.titulo.Contains(textoBuscar);
        }
        public virtual string ToString()
        {
            return "Autor: " + this.autor + " | Titulo: " + this.titulo + " | Ubicacion: " + this.ubicacion;
        }
    }
}
