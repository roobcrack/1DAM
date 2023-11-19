/*Crea un programa escriba 4 veces los números del 1 al 5, en una misma
línea, usando "while": 12345123451234512345.*/

using System;

class Ejercicio_2_2_5_2
{
	static void Main()
	{
		int i=0;
		
		while(i < 5)
		{
			int j = 0;
			
			i++;
			while(j < 5)
			{
				j++;
				Console.Write(j);
			}
		}
	}
}
