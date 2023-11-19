//Ruben Martinez Martinez
/*Amplia el programa del ejercicio 4.3.1.1, para que almacene datos de
hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una
nueva canción, mostrar el título de todas las canciones, buscar la canción que
contenga un cierto texto (en el artista o en el título)*/

using System;

class Ejercicio_4_3_2_1{
	struct songData{
		public string artist;
		public string title;
		public int length;
		public int size;
	}
	
	static void Main(){
		songData[] song = new songData[100];
		int input, totalSongs=0;
		string text;
		
		while(true){
			Console.WriteLine();
			Console.WriteLine("Select what you want to do");
			Console.WriteLine("1.Add new song");
			Console.WriteLine("2.Show all titles");
			Console.WriteLine("3.Search text in artist");
			Console.WriteLine("4.Search text in title");
			Console.WriteLine("0.Exit");
			Console.Write("Insert: ");
			input = Convert.ToInt32(Console.ReadLine());
			
			if(input==0){ break; }
			switch(input){
				case 1: 
					Console.WriteLine("Insert the data of a song");
					Console.Write("Insert artist name: ");
					song[totalSongs].artist = Console.ReadLine();
					Console.Write("Insert the title: ");
					song[totalSongs].title = Console.ReadLine();
					Console.Write("Insert the length: ");
					song[totalSongs].length = 
						Convert.ToInt32(Console.ReadLine());
					Console.Write("Insert the size: ");
					song[totalSongs].size = Convert.ToInt32(Console.ReadLine());
					totalSongs++;
					break;
				case 2: 
					for(int i=0; i<totalSongs; i++){
						Console.WriteLine("Here you have all the songs");
						Console.Write("{0} ", song[i].title);
					}
					Console.WriteLine();
					break;
				case 3: 
					Console.WriteLine("Type the text you want to search");
					Console.Write("Insert: ");
					text = Console.ReadLine();
					
					for(int i=0; i<totalSongs; i++){
						if(song[i].artist.IndexOf(text) >= 0){
							Console.Write("{0} ", song[i].artist);
						}
					}
					break;
				case 4: 
					Console.WriteLine("Type the text you want to search");
					Console.Write("Insert: ");
					text = Console.ReadLine();
					
					for(int i=0; i<totalSongs; i++){
						if(song[i].title.IndexOf(text) >= 0){
							Console.Write("{0} ", song[i].title);
						}
					}
					break;
				default: Console.WriteLine("Not founded");
					break;
			}
		}
	}
}
