/*Crea un programa que escriba en pantalla los números pares del 26 al 10
(descendiendo), usando "do..while".*/

using System;

class Ejercicio_2_2_2_3
{
	static void Main()
	{
		Console.WriteLine("Even numbers");
		int counter = 26;
		
		do
		{
			if (counter % 2 == 0)
			{
				Console.WriteLine("·{0}", counter);
			}
			counter = counter -1;
		}while(counter >= 10);
	}
}
