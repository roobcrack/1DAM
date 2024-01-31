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
                    Console.WriteLine("[5].Modificar documento");
                    Console.WriteLine("[0].Salir del programa");
                    Console.Write("Inserte: ");
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion < 0 || opcion > 5)
                            throw new Exception();
                        done = true;
                    } catch(Exception e){ Console.WriteLine("ERROR. Inserte un valor disponible.\n"); }
                }
                switch(opcion)
                {
                    case 0: //Salir del programa
                        Console.WriteLine("\nSaliendo del programa. . .");
                        break;

                   /* case 1: //Añadir nuevo documento
                        int opcionCrear = 0;
                        done = false;

                        if (ld.Cantidad < ld.Capacidad)
                        {
                            while (!done)
                            {
                                Console.WriteLine("\nQue quiere que sea: ");
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
                                    if (opcionCrear == 0) { break; }

                                    string autor = PedirCadena("autor");
                                    string titulo = PedirCadena("titulo");
                                    string ubicacion = PedirCadena("ubicacion");
                                    if (opcionCrear == 1)
                                        ld.Crear(new Documento(autor, titulo, ubicacion));
                                    else if (opcionCrear == 2)
                                    {
                                        bool exit = false;
                                        int paginas=0;
                                            
                                        while (!exit)
                                        {
                                            try
                                            {
                                                paginas = PedirEntero("paginas");
                                                if (paginas <= 0) throw new Exception();
                                                exit = true;
                                            } catch(Exception) { Console.WriteLine("ERROR. Valor no disponible\n"); }
                                        }
                                        ld.Crear(new Libro(autor, titulo, ubicacion, paginas));
                                    } else
                                    {
                                        string procedencia = PedirCadena("procedencia");
                                        ld.Crear(new Articulo(autor, titulo, ubicacion, procedencia));
                                    }
                                        done = true;
                                } catch (Exception e){ Console.WriteLine("ERROR. Valor no disponible.\n"); }
                            }
                        } else{ Console.WriteLine("ERROR. Maximo de ficheros alcanzado \"1000\""); }
                        Console.WriteLine();
                        break;*/
                    case 2: //Mostrar documentos
                        Console.WriteLine("\n"+ld.Mostrar());
                        break;
                    case 3: //Contiene texto
                        Console.Write("Introduzca el texto: ");
                        string textoBuscar = Console.ReadLine();
                        Console.WriteLine("\n"+ld.Buscar(textoBuscar));
                        break;
                    case 4: //Borrar documento
                        int posicionBorrar = 0;
                        Console.Write("Numero del documento que quiera borrar: ");
                        try
                        {
                            posicionBorrar = Convert.ToInt32(Console.ReadLine());
                            if (posicionBorrar < 1 || posicionBorrar > ld.Cantidad)
                                throw new Exception();
                            ld.Borrar(posicionBorrar);
                        }
                        catch (Exception){ Console.WriteLine("ERROR. Valor no disponible."); }
                        break;
                    case 5: //Modificar documento
                        Console.Write("Seleccione que documento quiere modificar: ");
                        int numero=0;
                        try
                        {
                            numero = Convert.ToInt32(Console.ReadLine());

                            string autor = PedirCadena("autor");
                            if (autor == "") { autor = ld.Documentos[numero].GetAutor(); }
                            string titulo = PedirCadena("titulo");
                            if(titulo == "") { titulo = ld.Documentos[numero].GetTitulo(); }
                            string ubicacion = PedirCadena("ubicacion");
                            if(ubicacion == "") { ubicacion = ld.Documentos[numero].GetUbicacion(); }

                            if (ld.Documentos[numero].GetType() == typeof(Documento))
                                ld.Documentos[numero] = new Documento(autor, titulo, ubicacion);
                            else if (ld.Documentos[numero].GetType() == typeof(Libro))
                            {

                            }
                        }
                        catch (Exception) { Console.WriteLine("ERROR. Valor no disponible\n"); }
                        break;
                }
            } while (opcion != 0);
        }
        static string PedirCadena(string texto)
        {
            Console.Write("Inserte {0}: ", texto);
            return Console.ReadLine();
        }
        static int PedirEntero(string texto)
        {
            Console.Write("Inserte {0}: ", texto);
            return Convert.ToInt32(Console.ReadLine());
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