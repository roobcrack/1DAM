using System;

namespace Libro
{
    internal class Libro : Documento
    {
        protected int paginas { get; set; }
        public override void CrearDocumento()
        {
            base.CrearDocumento();
            Console.Write("Introduce paginas: ");
            this.paginas = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() + " | Paginas: " + this.paginas;
        }
    }
}
