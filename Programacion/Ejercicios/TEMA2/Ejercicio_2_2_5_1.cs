/*Crea un programa escriba 4 veces los números del 1 al 5, en una misma
línea, usando "for": 12345123451234512345*/

using System;

class Ejercicio_2_2_5_1
{
	static void Main()
	{
		for(int i=1; i<=4; i++)
		{
			for(int j=1; j<=4; j++)
			{
				Console.Write(j);
			}
		}
	}
}
