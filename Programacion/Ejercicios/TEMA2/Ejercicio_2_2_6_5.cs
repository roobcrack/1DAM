/*Dibuja un triángulo de asteriscos descendente. Por ejemplo, si el usuario
escoge "4" como tamaño, la primera fila tendrá 4 asteriscos, la segunda tendrá 
3, la siguiente tendrá 2 y la última tendrá 1.*/

using System;

class Ejercicio_2_2_6_5
{
	static void Main()
	{
		int triangleBase;
		
		Console.Write("Enter the base of the triangle: ");
		triangleBase = Convert.ToInt32(Console.ReadLine());
		
		for(int i=triangleBase; i>0; i--)
		{
			for(int j=0; j<i; j++){
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
