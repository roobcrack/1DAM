//Ruben Martinez Martinez
/*Crea un "struct" que almacene datos de una canción en formato MP3:
Artista, Título, Duración (en segundos), Tamaño del fichero (en KB). Un programa
debe pedir los datos de una canción al usuario, almacenarlos en dicho "struct" y
después mostrarlos en pantalla*/

using System;

class Ejercicio_4_3_1_1{
	struct songData{
		public string artist;
		public string title;
		public int length;
		public int size;
	}
	
	static void Main(){
		songData song;
		
		Console.WriteLine("Insert the data of a song");
		Console.Write("Insert artist name: ");
		song.artist = Console.ReadLine();
		Console.Write("Insert the title: ");
		song.title = Console.ReadLine();
		Console.Write("Insert the length: ");
		song.length = Convert.ToInt32(Console.ReadLine());
		Console.Write("Insert the size: ");
		song.size = Convert.ToInt32(Console.ReadLine());
			
		Console.WriteLine("Artist: {0}, Title: {1}, Length: {2}s, Size: {3}kb",
			song.artist, song.title, song.length, song.size);
	}
}
