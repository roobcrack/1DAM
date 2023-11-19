/*Mejora la solución al ejercicio 2.1.3.1, usando "else".*/

using System;

class Ejercicio_2_1_4_1
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		if(number1 == 0)
		{
			Console.WriteLine("Any product of 0 is 0");
		}else
		{
			Console.Write("Enter a second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("The product of {0} * {1} = {2}", 
				number1, number2, number1 * number2);
		}
	}
}
