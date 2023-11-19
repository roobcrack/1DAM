/*Crea un "calculador de cuadrados": pedirá al usuario un número y
mostrará su cuadrado. Se repetirá mientras el número introducido no sea cero
(usa "while" para conseguirlo).*/

using System;
class Ejercicio_2_2_1_1_2
{
	static void Main()
	{
		int number, result;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		while (number != 0)
		{
			result = number * number;
			
			Console.WriteLine("The square of {0} = {1}", number, result);
			Console.WriteLine();
			Console.Write("Enter other number: ");
			number = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("The square of 0 is 0");
	}
}
