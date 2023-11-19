/*Crea un programa que pida al usuario dos números enteros y diga si uno
y sólo uno es par*/

using System;

class Ejercicio_2_1_5_7
{
	static void Main()
	{
		int number1, number2;

		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter one number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if(((number1 % 2 != 0) && (number2 % 2 == 0)) || 
			((number1 % 2 == 0) && (number2 % 2 != 0)))
		{
			Console.WriteLine("{0} and {1}, one of them is odd", number1, number2);
		}else
		{
			Console.WriteLine("{0} or {1}, none or both are odd", number1, number2);
		}
	}
}
