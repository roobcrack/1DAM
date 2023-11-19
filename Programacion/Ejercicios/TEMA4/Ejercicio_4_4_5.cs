//Ruben Martinez Martinez

using System;

class Ejercicio_4_4_5{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++){
					Console.WriteLine("{0}-Exercise 4.4.5.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_5_1();
					break;
				case "2": Ejercicio_4_4_5_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Un programa que pida al usuario 10 frases, las guarde en un array, y
luego le pregunte textos de forma repetitiva, e indique si cada uno de esos
textos aparece como parte de alguno de los elementos del array. Terminará cuando
el texto introducido sea "fin".*/
	static void Ejercicio_4_4_5_1(){
		string[] phrases = new string[10];
		string search;
		
		for(int i=0; i<10; i++){
			Console.Write("Insert phrase {0}: ", i+1);
			phrases[i] = Console.ReadLine();
		}
			
		do{	
			Console.Write("What you want to search: ");
			search = Console.ReadLine();
			
			for(int i=0; i<10; i++){
				if(phrases[i].Contains(search)){
					Console.WriteLine("It is in phrase {0}. ", i+1);
				}
			}
		} while(search!="end");
	}
	
/*Crea una versión del ejercicio 4.4.5.1 en la que, en caso de que alguno de
los textos aparezca como subcadena, se avise además si se encuentra
exactamente al principio.*/
	static void Ejercicio_4_4_5_2(){
		string[] phrases = new string[10];
		string search;
		
		for(int i=0; i<10; i++){
			Console.Write("Insert phrase {0}: ", i+1);
			phrases[i] = Console.ReadLine();
		}
			
		do{	
			Console.Write("What you want to search: ");
			search = Console.ReadLine();
			
			for(int i=0; i<10; i++){
				if(phrases[i].Contains(search)){
					Console.WriteLine("It is in phrase {0}. ", i+1);
					if(phrases[i].Substring(0,search.Length).Contains(search)){
						Console.WriteLine(" It is in the beginning");
					}
				}
			}
		} while(search!="end");	
	}
}
