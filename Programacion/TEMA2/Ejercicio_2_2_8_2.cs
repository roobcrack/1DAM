/*Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos,
como en el ejercicio 2.2.6.2. Deberás usar las variables "ancho" y "alto" para 
los datos que pidas al usuario, y las variables "filaActual" y "columnaActual"
(declaradas en el "for") para el bloque repetitivo.*/

using System;

class Ejercicio_2_2_8_2
{
	static void Main()
	{
		int height, width;
		
		Console.Write("Enter the height: ");
		height = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the width: ");
		width = Convert.ToInt32(Console.ReadLine());
		
		
		for(int actualHeight=0; actualHeight<height; actualHeight++)
		{
			for(int actualWidth=0; actualWidth<width; actualWidth++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
