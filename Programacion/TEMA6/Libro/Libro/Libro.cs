using System;

namespace Libro
{
    internal class Libro
    {
        protected string autor { get; set; }
        protected string titulo { get; set; }
        protected string ubicacion { get; set; }
        public Libro(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }
        public void MostrarLibro()
        {
            Console.WriteLine("Autor: {0}, Titulo: {1}, Ubicacion: {2}", autor, titulo, ubicacion);
        }
    }
}
