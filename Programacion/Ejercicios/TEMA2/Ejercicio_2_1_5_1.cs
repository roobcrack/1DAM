/*Crea un programa que pida al usuario un número entero y responda si es
múltiplo de 2 o de 3.*/

using System;

class Ejercicio_2_1_5_1
{
	static void Main()
	{
		int number;

		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		if((number % 2 == 0) || (number % 3 == 0))
		{
			Console.WriteLine("{0} is multiple of 2 or 3", number);
		}else
		{
			Console.WriteLine("{0} is not multiple of 2 or 3", number);
		}
	}
}
