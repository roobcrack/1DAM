/*Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) 
o algún otro carácter, usando "switch" (pista: necesitarás que usar un dato de 
tipo "char").*/

using System;

class Ejercicio_2_1_9_2
{
	static void Main()
	{
		char input;
		
		Console.Write("Type your input(must be one character): ");
		input = Convert.ToChar(Console.ReadLine());
		
		switch (input)
		{
			case ',':
			case '.': 
			case ';': 
			case ':': Console.WriteLine("The input is a punctuation sign");
				break;
				
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case '0': Console.WriteLine("The input is a number");
				break;
				
			default: Console.WriteLine("Input is some other character");
				break;
		}
	}
}
