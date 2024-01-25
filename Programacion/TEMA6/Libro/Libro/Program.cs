using System;

namespace Libro
{
    class Program
    {
        static void Main()
        {
            Documento[] documento = new Documento[1000];
            int contadorLibros = 0, opcion;

            do
            {
                Console.WriteLine("Seleccione opcion: ");
                Console.WriteLine("1.Añadir nuevo libro");
                Console.WriteLine("2.Mostrar libros libro");
                Console.WriteLine("0.Salir del programa");
                Console.Write("Inserte: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch(opcion)
                {
                    case 0: 
                        Console.WriteLine("Saliendo del programa. . .");
                        break;

                    case 1:
                        string autor = "", titulo = "", ubicacion = "";
                        int paginas = 0;

                        Console.WriteLine("Que quiere que sea: ");
                        Console.WriteLine("1.Libro");
                        Console.WriteLine("2.Documento");
                        Console.Write("Inserte: ");
                        int opcionLibro = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        CrearLibro(ref autor, ref titulo, ref ubicacion, ref paginas, opcionLibro);
                        switch (opcionLibro)
                        {
                            case 1:
                                documento[contadorLibros] = new Libro(autor, titulo, ubicacion, paginas);
                                contadorLibros++;
                                break;

                            case 2:
                                documento[contadorLibros] = new Documento(autor, titulo, ubicacion);
                                contadorLibros++;
                                break;
                        }
                        

                        break;

                    case 2:
                        MostrarLibros(documento, contadorLibros);
                        break;

                    default:
                        Console.WriteLine("Seleccione una de las opciones permitidas.");
                        break;
                }
            } while (opcion != 0);
        }
        public static void MostrarLibros(Documento[] documento, int contadorLibros)
        {
            for (int i = 0; i < contadorLibros; i++)
            {
                documento[i].Mostrar();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void CrearLibro(ref string autor, ref string titulo, 
            ref string ubicacion, ref int paginas, int tipo)
        {
            Console.Write("Introduce el nombre del autor: ");
            autor = Console.ReadLine();
            Console.Write("Introduce el titulo: ");
            titulo = Console.ReadLine();
            Console.Write("Introduce la ubicacion: ");
            ubicacion = Console.ReadLine();
            if (tipo == 1)
            {
                Console.Write("Introduce las paginas: ");
                paginas = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
}