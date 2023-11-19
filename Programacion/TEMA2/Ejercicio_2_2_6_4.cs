/*Crea un triángulo de asteriscos, que mostrará uno en la primera fila, dos
en la segunda, tres en la tercera y así sucesivamente, hasta llegar al tamaño
indicado por el usuario.*/

using System;

class Ejercicio_2_2_6_4
{
	static void Main()
	{
		int triangleBase;
		
		Console.Write("Enter the base of the triangle: ");
		triangleBase = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0; i<triangleBase; i++)
		{
			for(int j=0; j<i; j++){
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
