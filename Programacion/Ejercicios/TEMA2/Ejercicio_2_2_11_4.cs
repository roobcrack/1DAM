/*Crea una versión alternativa del ejercicio 2.2.11.2, que no emplee
"continue" sino el "if" contrario.*/

using System;

class Ejercicio_2_2_11_4
{
	static void Main()
	{
		for(int i=2; i<=106; i++)
		{
			if(i % 10 == 0)
			{
				continue;
			}else if(i % 2 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
