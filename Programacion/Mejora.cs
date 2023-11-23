using System;
class Ejemplo_04_06a {
	struct tipoFicha {
		public string nombreFich;
		public long tamanyo;
	}
	
	static void Main() {
		tipoFicha[] fichas = new tipoFicha[1000];
		int numeroFichas=0;
		int opcion; 
		string textoBuscar; 
		long tamanyoBuscar; 
		bool done = false;

		do {

			Console.WriteLine();
			Console.WriteLine("Escoja una opción:");
			Console.WriteLine("1.- Añadir datos de un nuevo fichero");
			Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
			Console.WriteLine("3.- Mostrar ficheros por encima de un cierto " +
				"tamaño");
			Console.WriteLine("4.- Ver datos de un fichero");
			Console.WriteLine("5.- Buscar nombre o parte");
			Console.WriteLine("6.- Salir");
			opcion = Convert.ToInt32( Console.ReadLine() );

			switch(opcion) {
				case 1: 
					if (numeroFichas < 1000) { 
						while(!done){
							try{
								Console.WriteLine("Introduce el nombre del fichero: ");
								fichas[numeroFichas].nombreFich = Console.ReadLine();
								if(fichas[numeroFichas].nombreFich == ""){
									throw new Exception("It must have a name");
								}
								Console.WriteLine("Introduce el tamaño en KB: ");
								fichas[numeroFichas].tamanyo = Convert.ToInt32(
									Console.ReadLine() );
								if(fichas[numeroFichas].tamanyo < 0){
									throw new Exception("Number must be bigger than 0");
								} else{
									done=true;
								}
							} catch(Exception e){ Console.WriteLine(e.Message); }
							
							
						}
					
						numeroFichas++;
					} else 
						Console.WriteLine("Máximo de fichas alcanzado (1000)!");
					break;
					
				case 2: // Mostrar todos
					for (int i=0; i<numeroFichas; i++)
						Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
							fichas[i].nombreFich, fichas[i].tamanyo);
					break;
				
				case 3: 
					Console.WriteLine("¿A partir de que tamaño quieres ver?");
					tamanyoBuscar = Convert.ToInt64( Console.ReadLine() );
					for (int i=0; i < numeroFichas; i++)
						if (fichas[i].tamanyo >= tamanyoBuscar)
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
								fichas[i].nombreFich, fichas[i].tamanyo);
					break;
				
				case 4: 
					Console.WriteLine("¿De qué fichero quieres ver todos los "+
					"datos?");
					textoBuscar = Console.ReadLine();
					for (int i=0; i < numeroFichas; i++)
						if ( fichas[i].nombreFich == textoBuscar )
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
								fichas[i].nombreFich, fichas[i].tamanyo);
					break;
				
				case 5: 
					Console.WriteLine("Introduzca el nombre a buscar: ");
					string parteNombre = Console.ReadLine();
					for (int i=0; i < numeroFichas; i++)
						if ( fichas[i].nombreFich.Contains(parteNombre))
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
								fichas[i].nombreFich, fichas[i].tamanyo);
					break;
				
				case 6:
					Console.WriteLine("Fin del programa");
					break;
				
				default:
					Console.WriteLine("Opción desconocida!");
					break;
			}
		} while (opcion != 5);
	}
}
