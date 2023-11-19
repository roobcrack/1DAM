//Ruben Martinez Martinez
/*Crea un programa que permita guardar datos de "imágenes" (ficheros de
ordenador que contengan fotografías o cualquier otro tipo de información gráfica
). De cada imagen se debe guardar: nombre (texto), ancho en píxeles (por ejemplo
2000), alto en píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). El
programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando
su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva, 
ver todas las fichas (número y nombre de cada imagen), buscar la ficha que tenga
un cierto nombre.*/

using System;

class Ejercicio_4_3_2_2{
	struct fileData{
		public string name;
		public int width;
		public int height;
		public int size;
	}
	static void Main(){
		fileData[] files = new fileData[700];
		const int capacity = 700;
		int amount=0, insert;
		string name;
		
		while(true){
			Console.WriteLine("Choose what you want to do");
			Console.WriteLine("1.Add new file");
			Console.WriteLine("2.Show all files");
			Console.WriteLine("3.Search file");
			Console.WriteLine("0.Exit");
			Console.Write("Insert: ");
			insert = Convert.ToInt32(Console.ReadLine());
			
			if(insert==0){ break; }
			
			Console.WriteLine();
			switch(insert){
				case 1: 
					if(amount<capacity){
						Console.WriteLine("Let's insert a new file");
						Console.Write("Name: ");
						files[amount].name = Console.ReadLine();
						Console.Write("Width: ");
						files[amount].width = Convert.ToInt32(Console.ReadLine());
						Console.Write("Height: ");
						files[amount].height = Convert.ToInt32(Console.ReadLine());
						Console.Write("Size: ");
						files[amount].size = Convert.ToInt32(Console.ReadLine());
						amount++;
					}else{
						Console.WriteLine("The filas save data is full");
					}
					break;
				case 2:
					for(int i=0; i<amount; i++){
						Console.WriteLine("File {0}. Name: {1}  Width: {2} " + 
							"Height: {3}  Size: {4}", i+1, files[i].name, 
							files[i].width, files[i].height, files[i].size);
					}
					break;
				case 3: 
					Console.Write("Type the name that you want to search: ");
					name = Console.ReadLine();
					
					for(int i=0; i<amount; i++){
						if(files[i].name.IndexOf(name) >= 0){
							Console.WriteLine("File {0}, name: {1}", 
								i+1, files[i].name);
						}
					}
					break;
				default: Console.WriteLine("Not founded");
					break;
			}
			Console.WriteLine();
		}
	}
}
