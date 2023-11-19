/*Haz un programa que muestre tantos asteriscos (en la misma línea)
como indique el usuario.*/

using System;

class Ejercicio_2_2_1_2_4
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		while(number > 0)
		{
			Console.Write("*");
			number = number - 1;
		}
	}
}
