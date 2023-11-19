
/*Crea un programa que "dibuje" un triángulo creciente, alineado a la
derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice 
que desea 4 caracteres de alto, el triángulo sería así:
   *
  **
 ***
****
*/

using System;

class Ejercicio_2_5_8
{
	static void Main()
	{
		int baseTriangle;
		
		Console.Write("Insert the base number: ");
		baseTriangle = Convert.ToInt32(Console.ReadLine());
		
		for(int i=1; i<=baseTriangle; i++)
		{
			for(int j=baseTriangle; j>0; j--)
			{
				if(j > i)
				{
					Console.Write(" ");
				}else
				{
					Console.Write("*");
				}
			}
			Console.WriteLine();
		}
	}
}
