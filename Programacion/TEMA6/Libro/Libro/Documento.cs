using System;

namespace Libro
{
    internal class Documento : Libro
    {
        protected int paginas { get; set; }
        public Documento(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }
      /*  public new void MostrarLibro()
        {
            Console.WriteLine("Autor: {0}, Titulo: {1}, Ubicacion: {2}", autor, titulo, ubicacion);
        }*/
    }
}
