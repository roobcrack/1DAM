//Ruben Martinez Martinez

using System;

class Ejercicio_4_4_3{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<3; i++){
					Console.WriteLine("{0}-Exercise 4.4.3.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_3_1();
					break;
				case "2": Ejercicio_4_4_3_2();
					break;
				case "3": Ejercicio_4_4_3_3();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
/*Un programa que te pida tu nombre y lo muestre en pantalla separando
cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan",
debería aparecer en pantalla "J u a n"*/
	static void Ejercicio_4_4_3_1(){
		
		Console.Write("Insert your name: ");
		string name = Console.ReadLine();
		
		for(int i=0; i<name.Length; i++){
			Console.Write("{0} ", name[i]);
		}
	}
	
/*Un programa que pida una frase al usuario y la muestra en orden inverso
(de la última letra a la primera).*/
	static void Ejercicio_4_4_3_2(){
		Console.Write("Enter a phrase: ");
		string phrase = Console.ReadLine();
		
		for(int i=phrase.Length; i>0; i--){
			Console.Write(phrase[i-1]);
		}
	}
	
/*Un programa que pida al usuario una frase, después una letra y
finalmente diga si aparece esa letra como parte de esa frase o no*/
	static void Ejercicio_4_4_3_3(){
		Console.Write("Insert a phrase: ");
		string phrase = Console.ReadLine();
		Console.Write("Insert a letter: ");
		char letter = Convert.ToChar(Console.ReadLine());
		
		for(int i=0; i<phrase.Length; i++){
			if(phrase[i] == letter){
				Console.WriteLine("It is in");
			}
		}
	}
}
