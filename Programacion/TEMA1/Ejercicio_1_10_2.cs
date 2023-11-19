/*Crea un programa que calcule la división de dos números introducidos por
el usuario, así como el resto de esa división.*/

using System;

class Ejercicio_1_10_2
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter the first numbre: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nThe division of {0} and {1} is {2}",
			number1, number2, number1 / number2);
	}
}

