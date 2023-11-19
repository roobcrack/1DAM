/*Crea un programa que escriba 4 líneas de texto, cada una de las cuales
estará formada por los números del 1 al 5*/

using System;

class Ejercicio_2_2_6_1
{
	static void Main()
	{
		for(int i=1; i<=4; i++)
		{
			for(int j=1; j<=5; j++)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}
}
