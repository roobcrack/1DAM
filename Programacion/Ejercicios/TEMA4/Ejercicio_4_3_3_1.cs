//Ruben Martinez Martinez
/*Amplia el programa 4.3.2.1, para que el campo "duración" se almacene
como minutos y segundos, usando un "struct" anidado que contenga a su vez
estos dos campos.*/

using System;

class Ejercicio_4_3_3_1{
	struct lengthData{
		public int seconds;
		public int minutes;
	}
	struct songData{
		public string artist;
		public string title;
		public lengthData length;
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
					Console.Write("Insert the minutes: ");
					song[totalSongs].length.minutes = 
						Convert.ToInt32(Console.ReadLine());
					Console.Write("Insert the seconds: ");
					song[totalSongs].length.seconds = 
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
