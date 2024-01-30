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
