//Ruben Martinez Martinez
/*Crea una función "ContarLetra", que reciba una cadena y una letra, y
devuelva la cantidad de veces que dicha letra aparece en la cadena. Por ejemplo,
si la cadena es "Barcelona" y la letra es 'a', debería devolver 2 (porque la "a"
aparece 2 veces).*/

using System;

class Ejercicio_5_5_4{
	static void Main(){
		Console.Write("Insert a phrase: ");
		string phrase = Console.ReadLine();
		Console.Write("Insert a letter: ");
		char letter = Convert.ToChar(Console.ReadLine());
		
		Console.WriteLine("The letter \"{0}\" is {1} times", letter, 
			CountLetters(phrase, letter)); 
	}
	
	static int CountLetters(string phrase, char letter){
		int counter=0;
		foreach(char l in phrase){
			if(l==letter){
				counter++;
			}
		}
		
		return counter;
	}
}
