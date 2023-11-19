/*Crea un programa que calcule el producto de dos números introducidos
por el usuario.*/

using System;

class Ejercicio_1_10_1
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter the first numbre: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nThe product of {0} and {1} is {2}",
			number1, number2, number1 * number2);
	}
}
