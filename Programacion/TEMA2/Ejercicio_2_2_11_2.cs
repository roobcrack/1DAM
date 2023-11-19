/*Crea un programa que escriba los números pares del 2 al 106, excepto
los que sean múltiplos de 10, usando "continue".*/

using System;

class Ejercicio_2_2_11_2
{
	static void Main()
	{
		for(int i=2; i<=106; i++)
		{
			if(i % 10 == 0)
			{
				continue;
			}else if(i % 2 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
