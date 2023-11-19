/*Crea un programa que escriba en pantalla los números del 1 al 10,
usando "while".*/

using System;

class Ejercicio_2_2_1_2_1
{
	static void Main()
	{
		int number = 0;
		
		while (number < 10)
		{
			number = number + 1;
			Console.WriteLine("·{0}", number);
		}
	}
}
