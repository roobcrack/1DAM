/*Crea un programa que pida al usuario dos números enteros y diga si
ambos son pares.*/

using System;

class Ejercicio_2_1_5_5
{
	static void Main()
	{
		int number1, number2;

		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter one number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if((number1 % 2 == 0) && (number2 % 2 == 0))
		{
			Console.WriteLine("{0} and {1} are even", number1, number2);
		}else
		{
			Console.WriteLine("{0} or {1} is odd", number1, number2);
		}
	}
}
