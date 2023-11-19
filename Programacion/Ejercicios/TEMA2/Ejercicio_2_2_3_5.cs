/*Crea un programa que muestre los primeros ocho números pares: 2 4 6 8
10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar
el doble del valor que hace de contador).*/

using System;

class Ejercicio_2_2_3_5
{
	static void Main()
	{
		Console.WriteLine("First 8 even numbers");
		
		for(int i=1; i<=8; i++)
		{
			Console.WriteLine(i*2);
		}
	}
}
