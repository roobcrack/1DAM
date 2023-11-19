/*Crea un programa que calcule un número elevado a otro, usando
multiplicaciones sucesivas*/

using System;

class Ejercicio_2_5_6
{
	static void Main()
	{
		int number1, number2, result;
		
		Console.Write("Insert a number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		result = number1;
		for(int i=1; i<number2; i++)
		{
			result = result * number1;
		}
		
		Console.WriteLine("{0}^{1} = {2}", number1, number2, result);
	}
}
