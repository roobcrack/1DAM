/*Crea un programa que muestre 5 veces las letras de la L (mayúscula) a la
N (mayúscula), en la misma línea, empleando dos "for" anidados.*/

using System;

class Ejercicio_2_2_7_2
{
	static void Main()
	{
		for(int i=0; i<5; i++)
		{
			for(char letter='L'; letter<='N'; letter++)
			{
				Console.Write(letter);
			}
			Console.WriteLine();
		}
	}
}
