using System;

namespace Libro
{
    class Program
    {
        static void Main()
        {
            Libro libro = new Libro("Joseba", "La meretriz", "Panama");
            //Documento documento = new Documento("Pepico", "Dolor", "Cuba");

            libro.MostrarLibro();
            //documento.MostrarLibro();
        }
    }
}