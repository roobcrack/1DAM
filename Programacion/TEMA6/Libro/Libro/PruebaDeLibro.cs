using System;

namespace Libro
{
    class PruebaDeLibro
    {
        static void Main()
        {
            ListaDeDocumentos ld = new ListaDeDocumentos();
            int opcion = 0;
            CrearDocumentos(ld);

            do
            {
                bool done = false;

                while (!done)
                {
                    Console.WriteLine("Seleccione opcion: ");
                    Console.WriteLine("[1].Añadir nuevo documento");
                    Console.WriteLine("[2].Mostrar documentos");
                    Console.WriteLine("[3].Contiene texto");
                    Console.WriteLine("[4].Borrar documento");
                    Console.WriteLine("[0].Salir del programa");
                    Console.Write("Inserte: ");
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion < 0 || opcion > 4)
                            throw new Exception();
                        else
                            done = true;
                    } catch(Exception e){ Console.WriteLine("ERROR. Inserte un valor disponible."); }
                }
                switch(opcion)
                {
                    case 0: //Salir del programa
                        Console.WriteLine("Saliendo del programa. . .");
                        break;

                    case 1: //Añadir nuevo documento
                        int opcionCrear = 0;
                        done = false;

                        if (ld.Cantidad < ld.Capacidad)
                        {
                            while (!done)
                            {
                                Console.WriteLine("Que quiere que sea: ");
                                Console.WriteLine("[1].Documento");
                                Console.WriteLine("[2].Libro");
                                Console.WriteLine("[3].Articulo");
                                Console.WriteLine("[0].Volver al menu");
                                Console.Write("Inserte: ");
                                try
                                {
                                    opcionCrear = Convert.ToInt32(Console.ReadLine());
                                    if (opcionCrear < 0 || opcionCrear > 3)
                                        throw new Exception();
                                    else
                                    {
                                        if (opcionCrear == 0) { break; }

                                        Console.Write("Inserte autor: ");
                                        string autor = Console.ReadLine();
                                        Console.Write("Inserte titulo: ");
                                        string titulo = Console.ReadLine();
                                        Console.Write("Inserte ubicacion: ");
                                        string ubicacion = Console.ReadLine();
                                        if (opcionCrear == 1)
                                            ld.Crear(new Documento(autor, titulo, ubicacion));
                                        else if (opcionCrear == 2)
                                        {
                                            bool exit = false;
                                            int paginas=0;
                                            Console.Write("Inserte paginas: ");
                                            while (!exit)
                                            {
                                                try
                                                {
                                                    paginas = Convert.ToInt32(Console.ReadLine());
                                                    if (paginas <= 0) throw new Exception();
                                                    else exit = true;
                                                } catch(Exception) { Console.WriteLine("ERROR. Valor no disponible"); }
                                            }
                                            ld.Crear(new Libro(autor, titulo, ubicacion, paginas));
                                        } else
                                        {
                                            Console.Write("Inserte procedencia: ");
                                            string procedencia = Console.ReadLine();
                                            ld.Crear(new Articulo(autor, titulo, ubicacion, procedencia));

                                        }
                                            
                                    }
                                        done = true;
                                } catch (Exception e){ Console.WriteLine("ERROR. Valor no disponible.\n"); }
                            }
                        } else{ Console.WriteLine("ERROR. Maximo de ficheros alcanzado \"1000\""); }
                        break;
                    case 2: //Mostrar documentos
                        Console.WriteLine(ld.Mostrar());
                        break;
                    case 3: //Contiene texto
                        Console.Write("Introduzca el texto: ");
                        string textoBuscar = Console.ReadLine();
                        Console.WriteLine();
                        ld.Buscar(textoBuscar);
                        break;
                    case 4: //Borrar documento
                        int posicionBorrar = 0;
                        Console.Write("Numero del documento que quiera borrar: ");
                        try
                        {
                            posicionBorrar = Convert.ToInt32(Console.ReadLine());
                            if (posicionBorrar < 1 || posicionBorrar > ld.Cantidad)
                                throw new Exception();
                            else
                                ld.Borrar(posicionBorrar);
                        }
                        catch (Exception){ Console.WriteLine("ERROR. Valor no disponible."); }
                        break;
                }
            } while (opcion != 0);
        }

        static void CrearDocumentos(ListaDeDocumentos ld)
        {
            ld.Crear(new Documento("Ruben Martinez", "Curriculum VITAE", "España"));
            ld.Crear(new Libro("Dmitri Glujovski", "Metro 2033", "Rusia", 544));
            ld.Crear(new Articulo("Alex Lopez", "La divasa", "España", "La bonita"));
            ld.Crear(new Libro("Isaac Asimov", "La fundacion", "Rusia", 230));
            ld.Crear(new Documento("Paco Alcaide", "Lista de la compra", "Xixona"));
        }
    }
}