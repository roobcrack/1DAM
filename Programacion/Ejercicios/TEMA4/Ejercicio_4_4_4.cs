//Ruben Martinez Martinez

using System;

class Ejercicio_4_4_4{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++){
					Console.WriteLine("{0}-Exercise 4.4.4.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_4_1();
					break;
				case "2": Ejercicio_4_4_4_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
/*Un programa que te pida tu nombre y lo muestre en pantalla separando
cada letra de la siguiente con un espacio, similar al 4.4.3.1, pero esta vez 
usando "Substring". Por ejemplo, si tu nombre es "Juan", debería aparecer en 
pantalla "J u a n".*/
	static void Ejercicio_4_4_4_1(){
		
		Console.Write("Insert your name: ");
		string name = Console.ReadLine();
		
		int max = name.Length;
		for(int i=1; i<=max; i++){
			string cut = name.Substring(i-1, i);
			Console.Write("{0} ", cut);
		}
	}
	
/*Un programa que te pida tu nombre y lo muestre en pantalla como un
triángulo creciente. Por ejemplo, si tu nombre es "Juan", debería aparecer en
pantalla:
J
Ju
Jua
Juan*/
	static void Ejercicio_4_4_4_2(){
		
		Console.Write("Insert your name: ");
		string name = Console.ReadLine();
		
		int max = name.Length;
		for(int i=1; i<=name.Length; i++){
			string cut = name.Substring(0, i);
			Console.WriteLine("{0} ", cut);
		}
	}
}
