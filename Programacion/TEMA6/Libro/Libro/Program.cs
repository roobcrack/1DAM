using System;

namespace Libro
{
    class Program
    {
        static void Main()
        {
            Documento[] documento = new Documento[1000];
            int contadorDocumentos = 0, opcion=0;
            CrearDocumentos(documento, ref contadorDocumentos);

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
                        else
                            done = true;
                    } catch(Exception e)
                    {
                        Console.WriteLine("ERROR. Inserte un valor disponible.");
                        LimpiarPantalla();
                    }
                    Console.Clear();
                }
                switch(opcion)
                {
                    case 0: //Salir del programa
                        Console.WriteLine("Saliendo del programa. . .");
                        break;

                    case 1: //Añadir nuevo documento
                        int opcionLibro = 0;
                        done = false;

                        if (contadorDocumentos < 1000)
                        {
                            while (!done)
                            {
                                Console.WriteLine("Que quiere que sea: ");
                                Console.WriteLine("[1].Libro");
                                Console.WriteLine("[2].Articulo");
                                Console.WriteLine("[0].Volver al menu");
                                Console.Write("Inserte: ");
                                try
                                {
                                    opcionLibro = Convert.ToInt32(Console.ReadLine());
                                    if (opcion < 0 || opcion > 2)
                                        throw new Exception();
                                    else
                                        done = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("ERROR. Valor no disponible.\n");
                                }
                            }
                            Console.WriteLine();

                            if (opcionLibro == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            else if (opcionLibro == 1)
                                documento[contadorDocumentos] = new Libro();
                            else if (opcionLibro == 2)
                                documento[contadorDocumentos] = new Articulo();
                            documento[contadorDocumentos].RellenarDocumento();
                            contadorDocumentos++;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("ERROR. Maximo de ficheros alcanzado \"1000\"");
                            LimpiarPantalla();
                        }
                        break;
                    case 2: //Mostrar documentos
                        MostrarDocumentos(documento, contadorDocumentos);
                        LimpiarPantalla();
                        break;
                    case 3: //Contiene texto
                        MostrarDocumentos(documento, contadorDocumentos);
                        Console.Write("Introduzca el texto: ");
                        string textoBuscar = Console.ReadLine();
                        Console.WriteLine();
                        for (int i=0; i<contadorDocumentos; i++)
                        {
                            if (documento[i].Contiene(textoBuscar))
                            {
                                Console.Write("{0}. ", i + 1);
                                Console.WriteLine(documento[i].ToString());
                            }
                        }
                        Console.WriteLine();
                        LimpiarPantalla();
                        break;
                    case 4: //Borrar documento
                        int opcionBorrar = 0;
                        MostrarDocumentos(documento, contadorDocumentos);
                        Console.Write("Numero del documento que quiera borrar: ");
                        try
                        {
                            opcionBorrar = Convert.ToInt32(Console.ReadLine());
                            if (opcionBorrar < 1 || opcionBorrar > contadorDocumentos)
                                throw new Exception();
                            else
                                for (int i = opcionBorrar; i < contadorDocumentos; i++)
                                    documento[i] = documento[i + 1];
                                contadorDocumentos--;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("ERROR. Valor no disponible.");
                            LimpiarPantalla();
                        }
                        Console.Clear();
                        break;
                    case 5: //Modificar documento
                        int opcionModificar = 0;

                        MostrarDocumentos(documento, contadorDocumentos);
                        Console.Write("Introduzca que documento quiere modificar: ");
                        try
                        {
                            opcionModificar = Convert.ToInt32(Console.ReadLine());
                            if (opcionModificar < 1 || opcionModificar > contadorDocumentos)
                                throw new Exception();
                            else
                                documento[opcionModificar-1].RellenarDocumento();
                        } catch (Exception)
                        {
                            Console.WriteLine("ERROR. Valor no disponible.");
                            LimpiarPantalla();
                        }
                        Console.Clear();
                        break;
                }
            } while (opcion != 0);
        }

        public static void MostrarDocumentos(Documento[] documento, int contadorDocumentos)
        {
            for (int i = 0; i < contadorDocumentos; i++)
            {
                Console.Write("{0}. ", i + 1);
                Console.WriteLine(documento[i].ToString());
            }
            Console.WriteLine();
        }

        public static void LimpiarPantalla()
        {
            Console.Write("Pulse cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.Clear();
        }
        public static void CrearDocumentos(Documento[] doc, ref int cont)
        {
            doc[cont] = new Libro("Dmitri Glujovski", "Metro 2033", "Rusia", 544);
            cont++;
            doc[cont] = new Articulo("Alex Lopez", "La divasa", "España", "La bonita");
            cont++;
            doc[cont] = new Libro("Isaac Asimov", "La fundacion", "Rusia", 230);
            cont++;
        }
    }
}