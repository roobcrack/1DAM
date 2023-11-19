//Ruben Martinez Martinez

using System;

class Ejercicio_4_4_7{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++){
					Console.WriteLine("{0}-Exercise 4.4.7.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_7_1();
					break;
				case "2": Ejercicio_4_4_7_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Un programa que pida al usuario una frase y muestre sus palabras en
orden inverso.*/
	static void Ejercicio_4_4_7_1(){
		Console.Write("Insert a phrase: ");
		string phrase = Console.ReadLine();
		
		string[] phrases = phrase.Split();
		
		for(int i=phrases.Length-1; i>=0; i--){
			Console.Write("{0} ", phrases[i]);
		}
		Console.WriteLine();
	}
	
/*Un programa que pida al usuario varios números separados por espacios
y muestre su suma.*/
	static void Ejercicio_4_4_7_2(){
		Console.Write("Enter numbers separated by spaces: ");
		string number = Console.ReadLine();
		
		string[] numbers = number.Split();
		
		int result=0;
		for(int i=numbers.Length-1; i>=0; i--){
			result = result + Convert.ToInt32(numbers[i]);
		}
		Console.WriteLine("The addition is: {0}", result);
	}
}
