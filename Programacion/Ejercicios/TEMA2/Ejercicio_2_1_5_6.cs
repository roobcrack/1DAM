/*Crea un programa que pida al usuario dos números enteros y diga si (al
menos) uno es par.*/

using System;

class Ejercicio_2_1_5_6
{
	static void Main()
	{
		int number1, number2;

		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter one number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if((number1 % 2 != 0) || (number2 % 2 != 0))
		{
			Console.WriteLine("{0} and {1}, at least one is odd", 
				number1, number2);
		}else
		{
			Console.WriteLine("{0} or {1}, none is odd", number1, number2);
		}
	}
}
