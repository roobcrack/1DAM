using System;
using System.IO;

public class Ejercicio_5_2_3 {
    struct tipoFicha {
        public string nombreFich;
        public long tamanyo;
    }
    
    static tipoFicha[] fichas = new tipoFicha[1000];
    static int numeroFichas = 0;

    static void Main() {
        try {
            LeerDatosDesdeFichero("datos_ficheros.txt");
            Console.WriteLine("Datos cargados desde el archivo.");
        } catch (Exception ex) {
            Console.WriteLine("Error al cargar datos desde el archivo: " + ex.Message);
        }

        int opcion;
        
        do {
            Console.WriteLine();
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1.- Añadir datos de un nuevo fichero");
            Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
            Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
            Console.WriteLine("4.- Ver datos de un fichero");
            Console.WriteLine("5.- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            
            switch(opcion) {
                case 1: AnyadirDato(); break;
                case 2: MostrarTodos(); break;
                case 3: MostrarSegunTamanyo(); break;
                case 4: VerTodosDatos(); break;
                case 5: 
                    Console.WriteLine("Volcando datos al archivo...");
                    VolcarDatosAFichero("datos_ficheros.txt");
                    Console.WriteLine("Fin del programa");
                    break;
                default: Console.WriteLine("Opción desconocida!"); break;
            }    
        } while (opcion != 5);
    } 
    
    static void AnyadirDato() {
        if (numeroFichas < 1000) {
            Console.WriteLine("Introduce el nombre del fichero: ");
            fichas[numeroFichas].nombreFich = Console.ReadLine();
            Console.WriteLine("Introduce el tamaño en KB: ");
            fichas[numeroFichas].tamanyo = Convert.ToInt64(Console.ReadLine());
            numeroFichas++;
        } else 
            Console.WriteLine("Máximo de fichas alcanzado (1000)!");
    }
    
    static void MostrarTodos() {
        for (int i = 0; i < numeroFichas; i++) {
            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
        }
    }
    
    static void MostrarSegunTamanyo() {
        long tamanyoBuscar;
        Console.WriteLine("¿A partir de qué tamaño quieres ver?");
        tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
        for (int i = 0; i < numeroFichas; i++) {
            if (fichas[i].tamanyo >= tamanyoBuscar) {
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
            }
        }
    }

    static void VerTodosDatos() {
        string textoBuscar;
        Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
        textoBuscar = Console.ReadLine();
        for (int i = 0; i < numeroFichas; i++) {
            if (fichas[i].nombreFich == textoBuscar) {
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);
            }    
        }
    }

    static void VolcarDatosAFichero(string nombreFichero) {
        using (StreamWriter sw = new StreamWriter(nombreFichero)) {
            sw.WriteLine(numeroFichas);
            for (int i = 0; i < numeroFichas; i++) {
                sw.WriteLine("{0}|{1}", fichas[i].nombreFich, fichas[i].tamanyo);
            }
        }
    }

    static void LeerDatosDesdeFichero(string nombreFichero) {
        if (File.Exists(nombreFichero)) {
            using (StreamReader sr = new StreamReader(nombreFichero)) {
                string linea = sr.ReadLine();
                if (linea != null) {
                    numeroFichas = Convert.ToInt32(linea);
                    for (int i = 0; i < numeroFichas; i++) {
                        linea = sr.ReadLine();
                        string[] campos = linea.Split('|');
                        fichas[i].nombreFich = campos[0];
                        fichas[i].tamanyo = Convert.ToInt64(campos[1]);
                    }
                }
            }
        } else {
            Console.WriteLine("El archivo de datos no existe. Se creará uno nuevo al salir.");
        }
    }
}

