/*Suma tres números tecleados por usuario.*/

using System;

class Ejercicio_1_10_3
{
	static void Main()
	{
		int number1, number2, number3;
		
		Console.Write("Enter the first number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the third number: ");
		number3 = Convert.ToInt32(Console.ReadLine());
		
		
		Console.WriteLine("\nThe result of {0} + {1} + {2} = {3}", 
			number1, number2, number3, number1 + number2+ number3);
	}
}
