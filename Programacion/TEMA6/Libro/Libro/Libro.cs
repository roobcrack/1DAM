using System;

namespace Libro
{
    internal class Libro : Documento
    {
        protected int paginas { get; set; }

        public Libro() { }
        public Libro(string autor, string titulo, string ubicacion, int paginas)
            :base(autor, titulo, ubicacion)
        {
            this.paginas = paginas;
        }
        public override void RellenarDocumento()
        {
            bool done = false;

            base.RellenarDocumento();
            while (!done)
            {
                Console.Write("Introduce el numero de paginas: ");
                try
                {
                    this.paginas = Convert.ToInt32(Console.ReadLine());
                    if (this.paginas <= 0)
                        throw new Exception();
                    else
                        done = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR. Introduzca un numero valido.");
                }
            }
        }
        public override string ToString()
        {
            return base.ToString() + " | Paginas: " + this.paginas;
        }
    }
}
