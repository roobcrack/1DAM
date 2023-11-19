/*Crea un programa calcule cuantas cifras tiene un número entero
positivo (pista: se puede hacer dividiendo varias veces entre 10).*/

using System;

class Ejercicio_2_2_1_2_3
{
	static void Main()
	{
		int number, counter = 1;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		while(number > 10)
		{
			number = number / 10;
			counter = counter + 1;
		}
		
		Console.WriteLine("Your number has {0} digits", counter);
	}
}
