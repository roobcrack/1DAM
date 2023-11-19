/*Mejora la solución al ejercicio 2.1.3.2, usando "else".*/

using System;

class Ejercicio_2_1_4_2
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if(number2 == 0)
		{
			Console.WriteLine("You can't divide by 0");
		}else
		{
			Console.WriteLine("{0} / {1} = {2}", 
				number1, number2, number1 / number2);
		}
	}
}
