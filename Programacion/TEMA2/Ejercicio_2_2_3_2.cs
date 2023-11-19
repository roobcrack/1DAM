/*Crea un programa que escriba en pantalla los números del 1 al 50 que
sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si el resto
de la división entre 3 resulta 0).*/

using System;

class Ejercicio_2_2_3_2
{
	static void Main()
	{
		Console.WriteLine("Multiples of 3");
		
		for(int i=1; i<=50; i++)
		{
			if(i % 3 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
