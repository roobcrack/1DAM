/*Crea un programa que, para los números entre el 10 y el 20 (ambos
incluidos) diga si son divisibles entre 5, si son divisibles entre 6 y 
si son divisibles entre 7, usando dos bucles anidados*/

using System;

class Ejercicio_2_2_5_3
{
	static void Main()
	{
		for(int i=5; i<=7; i++)
		{
			Console.WriteLine("Divisible numbers of {0}", i);
			for(int j=10; j<=20; j++)
			{
				if(j % i == 0)
				{
					Console.WriteLine(j);
				}
			}
			Console.WriteLine();
		}
	}
}
