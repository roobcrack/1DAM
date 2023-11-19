/*Crea un programa que muestre los números del 100 al 200 (ambos
incluidos) que sean divisibles entre 7 y a la vez entre 3.*/

using System;

class Ejercicio_2_2_3_3
{
	static void Main()
	{
		Console.WriteLine("Numbers that can be divided by 7 or 3");
		
		for(int i=100; i <= 200; i++)
		{
			if((i % 3 ==0) || (i % 7 == 0))
			{
				Console.WriteLine(i);
			}
		}
	}
}
