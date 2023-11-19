/*Crea una versión mejorada del programa anterior, que, tras introducir
cada par de números, responderá si el primero es múltiplo del segundo, o el
segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro.*/

using System;
class Ejercicio_2_2_1_1_4
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
			else if (number1 % number2 == 0)
			{
				Console.WriteLine("The second number is multiple of the first");
			}
			else
			{
				Console.WriteLine("None of them is multiple eachother");
			}
			Console.WriteLine();
			Console.WriteLine("Let's try again");
			
			Console.Write("Enter a number that isn't 0: ");
			number1 = Convert.ToInt32(Console.ReadLine());
		
			Console.Write("Enter other number that isn't 0: ");
			number2 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("You have entered 0");
	}
}
