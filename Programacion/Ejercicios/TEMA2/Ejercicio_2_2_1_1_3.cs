/*Crea un programa que pida de forma repetitiva pares de números al
usuario. Tras introducir cada par de números, responderá si el primero es múltiplo
del segundo. Se repetirá mientras los dos números sean distintos de cero
(terminará cuando uno de ellos sea cero).*/

using System;
class Ejercicio_2_2_1_1_3
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter a number that isn't 0: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number that isn't 0: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		while ((number1 != 0) || (number2 != 0))
		{
			if (number2 % number1 == 0)
			{
				Console.WriteLine("The first number is multiple of the second");
			}
			else 
			{
				Console.WriteLine();
				Console.WriteLine("The first number isn't multiple of the second");
			}
			Console.WriteLine("Let's try again");
			
			Console.Write("Enter a number that isn't 0: ");
			number1 = Convert.ToInt32(Console.ReadLine());
		
			Console.Write("Enter other number that isn't 0: ");
			number2 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("You have entered 0");
	}
}
