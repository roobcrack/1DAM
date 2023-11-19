//Ruben Martinez Martinez

using System;

class Ejercicio_4_4_6{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++){
					Console.WriteLine("{0}-Exercise 4.4.6.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_6_1();
					break;
				case "2": Ejercicio_4_4_6_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Una variante del ejercicio 4.4.5.2, que no distinga entre mayúsculas y
minúsculas a la hora de buscar.*/
	static void Ejercicio_4_4_6_1(){
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
				if(phrases[i].Contains(search.ToLower())){
					Console.WriteLine("It is in phrase {0}. ", i+1);
					if(phrases[i].Substring(0,search.Length).Contains(search)){
						Console.WriteLine(" It is in the beginning");
					}
				}
			}
		} while(search!="end");	
	}
	
/*Un programa que pida al usuario una frase y elimine todos los espacios
redundantes que contenga (debe quedar sólo un espacio entre cada palabra y la
siguiente)*/
	static void Ejercicio_4_4_6_2(){
		
	}
}
