/*Crea un programa que pida al usuario dos números enteros y diga "Uno
de los números es positivo", "Los dos números son positivos" o bien "Ninguno de
los números es positivo", según corresponda.*/

using System;

class Ejercicio_2_1_5_8
{
	static void Main()
	{
		int number1, number2;

		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter one number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if((number1 % 2 == 0) && (number2 % 2 == 0))
		{
			Console.WriteLine("Both of them are even");
		}else if((number1 % 2 == 0) || (number2 % 2 == 0))
		{
			Console.WriteLine("At least one of them is even");
		}else
		{
			Console.WriteLine("None of them is even");
		}
	}
}
