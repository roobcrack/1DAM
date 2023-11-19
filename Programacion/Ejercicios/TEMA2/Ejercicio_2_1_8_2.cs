/*Usa el operador condicional para calcular el menor de dos números.*/

using System;

class Ejercicio_2_1_8_2
{
	static void Main()
	{
		int number1, number2, result;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		result = number1 > number2 ? number1 : number2;
		
		Console.WriteLine("Number {0} is bigger", result);
	}
}
