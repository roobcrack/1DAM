using System;

namespace Libro
{
    class Program
    {
        static void Main()
        {
            Documento[] documento = new Documento[1000];
            int contadorDocumentos = 0, opcion;

            do
            {
                Console.WriteLine("Seleccione opcion: ");
                Console.WriteLine("1.Añadir nuevo documento");
                Console.WriteLine("2.Mostrar documentos");
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
                        Console.WriteLine("Que quiere que sea: ");
                        Console.WriteLine("1.Libro");
                        Console.WriteLine("2.Articulo");
                        Console.WriteLine("0.Volver al menu");
                        Console.Write("Inserte: ");
                        int opcionLibro = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (opcionLibro)
                        {
                            case 0: break;
                            case 1:
                                documento[contadorDocumentos] = new Libro();
                                documento[contadorDocumentos].CrearDocumento();
                                contadorDocumentos++;
                                break;

                            case 2:
                                documento[contadorDocumentos] = new Articulo();
                                documento[contadorDocumentos].CrearDocumento();
                                contadorDocumentos++;
                                break;
                        }
                        break;

                    case 2:
                        for (int i = 0; i < contadorDocumentos; i++)
                        {
                            Console.WriteLine(documento[i].ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Seleccione una de las opciones permitidas.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 0);
        }
    }
}