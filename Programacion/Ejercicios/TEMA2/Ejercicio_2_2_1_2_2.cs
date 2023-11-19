/*Crea un programa que escriba en pantalla los números pares del 26 al
10 (descendiendo), usando "while*/

using System;

class Ejercicio_2_2_1_2_2
{
	static void Main()
	{
		int counter= 26;
		
		while (counter >= 10)
		{
			if (counter % 2 == 0)
			{
				Console.WriteLine("·{0}", counter);
			}
			counter = counter -1;
		}
	}
}
