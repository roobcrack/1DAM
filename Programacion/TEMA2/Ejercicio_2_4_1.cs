/*Crea un programa que cuente cuantas veces aparece la letra 'a' en una
frase que teclee el usuario, utilizando "foreach".*/

using System;

class Ejercicio_2_4_1
{
	static void Main()
	{
		int count = 0;
		string stringInput = Console.ReadLine();
		
		foreach(char letter in stringInput)
		{
			if(letter == 'a')
			{
				count++;
			}
		}
		Console.WriteLine("There are {0} letters 'a'", count);
	}
}
