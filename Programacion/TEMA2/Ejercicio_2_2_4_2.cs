/*Crea un programa que contenga un bucle sin fin que muestre los
números enteros positivos a partir del uno, separados por un espacio 
en blanco.*/

using System;

class Ejercicio_2_2_4_2
{
	static void Main()
	{
		for (int i=0; ; i++)
		{
			if(i % 2 == 0)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}
