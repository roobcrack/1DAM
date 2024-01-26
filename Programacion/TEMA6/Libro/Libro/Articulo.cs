using System;

namespace Libro
{
    internal class Articulo : Documento
    {
        protected string? procedencia {  get; set; }

        public override void CrearDocumento()
        {
            base.CrearDocumento();
            Console.Write("Procedencia: ");
            this.procedencia = Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString() + " | Procedencia: " + this.procedencia;
        }
    }
}
