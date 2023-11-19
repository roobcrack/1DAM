/*Crea un programa que pida un número al usuario y escriba los múltiplos
de 9 que haya entre 1 y ese número. Debes usar llaves en todas las 
estructuras de control, aunque sólo incluyan una sentencia.*/

using System;

class Ejercicio_2_2_9_1
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter a number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Multiples of 9");
		for(int i=1; i<=number; i++)
		{
			if(i % 9 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
