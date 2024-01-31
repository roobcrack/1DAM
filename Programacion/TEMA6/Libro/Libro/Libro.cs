using System;

namespace Libro
{
    internal class Libro : Documento
    {
        protected int paginas { get; set; }
        public int GetPaginas() { return paginas; }

        public Libro(string autor, string titulo, string ubicacion, int paginas)
            :base(autor, titulo, ubicacion)
        {
            this.paginas = paginas;
        }
        public override string ToString()
        {
            return base.ToString() + " | Paginas: " + this.paginas;
        }
    }
}
