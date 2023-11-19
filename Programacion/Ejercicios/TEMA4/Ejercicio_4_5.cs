//Ruben Martinez Martinez

using System;

class Ejercicio_4_5{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<3; i++){
					Console.WriteLine("{0}-Exercise 4.5.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_5_1();
					break;
				case "2": Ejercicio_4_5_2();
					break;
				case "3": Ejercicio_4_5_3();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Un programa que pida tu nombre y lo muestre con un espacio entre cada
par de letras, usando "foreach"*/
	static void Ejercicio_4_5_1(){
		
		Console.Write("Insert your name: ");
		string name = Console.ReadLine();
		
		foreach(char letter in name){
			Console.Write("{0} ", letter);
		}
		Console.WriteLine();
	}
	
/*Un programa que pida al usuario una frase y la descomponga en
subcadenas separadas por espacios, usando "Split". Luego debe mostrar cada
subcadena en una línea nueva, usando "foreach".*/
	static void Ejercicio_4_5_2(){
		
		Console.Write("Insert a phrase: ");
		string phrase = Console.ReadLine();
		
		string[] words = phrase.Split();
		foreach(string word in words){
			Console.WriteLine(word);
		}
	}
	
/*Un programa que pida al usuario varios números separados por espacios y
muestre su suma (como el del ejercicio 4.4.7.2), empleando "foreach"*/
	static void Ejercicio_4_5_3(){
		int addition=0;
		
		Console.Write("Insert numbers separated by spaces: ");
		string insert = Console.ReadLine();
		
		string[] numbers = insert.Split();
		foreach(string number in numbers){
			addition = addition + Convert.ToInt32(number);
		}
		
		Console.WriteLine("The addition is: {0}", addition);
	}
}
