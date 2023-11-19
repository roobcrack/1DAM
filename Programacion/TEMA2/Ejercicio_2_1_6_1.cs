/*Crea una variante del ejemplo 02_01_06a, en la que la comparación de
igualdad sea correcta y en la que las variables aparezcan en el lado
derecho de la comparación y los números en el lado izquierdo.*/

using System;

class Ejercicio_2_1_6_1
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		if(number == 0)
		{
			Console.WriteLine("The number is 0");
		}else
		{
			if(number < 0)
			{
				Console.WriteLine("The number is negative");
			}else
			{
				Console.WriteLine("The number is positive");
			}
		}
	}
}
