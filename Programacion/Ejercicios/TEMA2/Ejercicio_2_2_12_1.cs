/*Crea un programa que escriba los números del 100 al 200, separados
por un espacio, sin avanzar de línea, usando "for". En la siguiente línea, 
vuelve a escribirlos usando "while".*/

using System;

class Ejercicio_2_2_12_1
{
	static void Main()
	{
		for(int i=100; i<=200; i++)
		{
			Console.Write("{0} ", i);
		}
		
		Console.WriteLine();
		
		int j=100;
		while(j<=200)
		{
			Console.Write("{0} ", j);
			j++;
		}
	}
}
