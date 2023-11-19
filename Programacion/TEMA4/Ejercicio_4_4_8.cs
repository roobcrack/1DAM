//Ruben Martinez Martinez

using System;

class Ejercicio_4_4_8{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++){
					Console.WriteLine("{0}-Exercise 4.4.8.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_8_1();
					break;
				case "2": Ejercicio_4_4_8_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Un programa que pida al usuario dos frases y diga cual sería la "mayor"
de ellas (la que aparecería en último lugar en un diccionario).*/
	static void Ejercicio_4_4_8_1(){
		
		Console.Write("Insert a word: ");
		string word1 = Console.ReadLine();
		Console.Write("Insert a second word: ");
		string word2 = Console.ReadLine();
		
		if(word1.CompareTo(word2) > 0){
			Console.WriteLine("{0} goes first", word1);
		} else{
			Console.WriteLine("{0} goes first", word2);
		}
	}
	
/*Un programa que pida al usuario cinco frases, las guarde en un array y
muestre la "mayor" de ellas.*/
	static void Ejercicio_4_4_8_2(){
		string[] phrases = new string[5];
		
		Console.WriteLine("Insert phrases");
		for(int i=0; i<5; i++){
			Console.Write("{0}: ", i+1);
			phrases[i] = Console.ReadLine();
		}
		
		string max = phrases[0];
		for(int i=0; i<5; i++){
			if(max.CompareTo(phrases[i]) < 0){
				max = phrases[i];
			}
		}
		
		Console.WriteLine("Max phrase is: {0}", max);
	}
}
