using System;

namespace Libro
{
    internal class Documento
    {
        protected string? autor { get; set; }
        protected string? titulo { get; set; }
        protected string? ubicacion { get; set; }
        public virtual void CrearDocumento()
        {
            Console.Write("Introduce el nombre del autor: ");
            this.autor = Console.ReadLine();
            Console.Write("Introduce el titulo: ");
            this.titulo = Console.ReadLine();
            Console.Write("Introduce la ubicacion: ");
            this.ubicacion = Console.ReadLine();
        }
        public virtual string ToString()
        {
            return "Autor: " + this.autor + " | Titulo: " + this.titulo + " | Ubicacion: " + this.ubicacion;
        }
    }
}
