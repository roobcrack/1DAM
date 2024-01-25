using System;

namespace Libro
{
    internal class Libro : Documento
    {
        protected int paginas { get; set; }
        public Libro(string autor, string titulo, string ubicacion, int paginas) 
            :base(autor, titulo, ubicacion)
        {
            this.paginas = paginas;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write("| Páginas: {0}", this.paginas);
        }
    }
}
