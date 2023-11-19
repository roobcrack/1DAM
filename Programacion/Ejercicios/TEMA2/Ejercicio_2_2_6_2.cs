/*Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
****
****
****
*/

using System;

class Ejercicio_2_2_6_2
{
	static void Main()
	{
		int height, width;
		
		Console.Write("Enter the height: ");
		height = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the width: ");
		width = Convert.ToInt32(Console.ReadLine());
		
		
		for(int i=0; i<height; i++)
		{
			for(int j=0; j<width; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
