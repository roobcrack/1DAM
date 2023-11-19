//Rubén Martínez Martínez

using System;

public class Ejercicio_5_2_3 {
	struct tipoFicha {
		public string nombreFich;
		public long tamanyo;
	}
	
	static tipoFicha[] fichas = new tipoFicha[1000];
	static int numeroFichas=0;

	static void Main() {
		int opcion;
		
		do {
			// Menu principal, repetitivo
			Console.WriteLine();
			Console.WriteLine("Escoja una opción:");
			Console.WriteLine("1.- Añadir datos de un nuevo fichero");
			Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
			Console.WriteLine("3.- Mostrar ficheros por encima de un cierto" + 
				"tamaño");
			Console.WriteLine("4.- Ver datos de un fichero");
			Console.WriteLine("5.- Salir");
			opcion = Convert.ToInt32( Console.ReadLine() );
			// Hacemos una cosa u otra según la opción escogida
			switch(opcion) {
				case 1: AnyadirDato(); break;
				case 2: MostrarTodos(); break;
				case 3: MostrarSegunTamanyo(); break;
				case 4: VerTodosDatos(); break;
				case 5: Console.WriteLine("Fin del programa"); break;
				default: Console.WriteLine("Opción desconocida!"); break;
			}	
		} while (opcion != 5); // Si la opcion es 5, terminamos
	} 
	
	static void AnyadirDato(){
		if (numeroFichas < 1000) { // Si queda hueco
			Console.WriteLine("Introduce el nombre del fichero: ");
			fichas[numeroFichas].nombreFich = Console.ReadLine();
			Console.WriteLine("Introduce el tamaño en KB: ");
			fichas[numeroFichas].tamanyo = Convert.ToInt32(
			Console.ReadLine() );
			// Y ya tenemos una ficha más
			numeroFichas++;
		} else // Si no hay hueco para más fichas, avisamos
		Console.WriteLine("Máximo de fichas alcanzado (1000)!");
	}
	
	static void MostrarTodos(){
		for (int i=0; i<numeroFichas; i++){
			Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
				fichas[i].nombreFich, fichas[i].tamanyo);
		}
	}
	
	static void MostrarSegunTamanyo(){
		long tamanyoBuscar;
		
		Console.WriteLine("¿A partir de que tamaño quieres ver?");
		tamanyoBuscar = Convert.ToInt64( Console.ReadLine() );
		for (int i=0; i<numeroFichas; i++){
			if (fichas[i].tamanyo >= tamanyoBuscar){
				Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
					fichas[i].nombreFich, fichas[i].tamanyo);
			}
		}
	}

	static void VerTodosDatos(){
		string textoBuscar;
		
		Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
		textoBuscar = Console.ReadLine();
		for (int i=0; i<numeroFichas; i++){
			if ( fichas[i].nombreFich == textoBuscar ){
				Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
					fichas[i].nombreFich, fichas[i].tamanyo);
			}	
		}
	}
}
