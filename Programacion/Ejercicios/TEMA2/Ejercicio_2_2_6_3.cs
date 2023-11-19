/*Haz un programa que dibuje un cuadrado de asteriscos, cuyo ancho (y
alto, que tendrá el mismo valor) será introducido por el usuario.*/

using System;

class Ejercicio_2_2_6_3
{
	static void Main()
	{
		int size;
		
		Console.Write("Enter how long you want the square to be: ");
		size = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0; i<size; i++)
		{
			for(int j=0; j<size; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
