/*Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una
fila (o columna) de asteriscos y cuyo interior esté formado por espacios en 
blanco, con el ancho y el alto que indique el usuario. Por ejemplo, si desea 
anchura 4 y altura 3, el rectángulo sería así:
****
* *
****
*/

using System;

class Ejercicio_2_5_7
{
	static void Main()
	{
		int width, height;
		
		Console.Write("Insert the height: ");
		height = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert the width: ");
		width = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0; i<height; i++)
		{
			for(int j=0; j<width; j++)
			{
				if(i==0 || j==0 || i==height-1 || j==width-1)
				{
					Console.Write("* ");
				}else
				{
						Console.Write("  ");
				}
			}
			Console.WriteLine();
		}
	}
}
