/*

Martinez Martinez, Ruben
Practica Evaluable Tema 2
Ejercicio 3		parcialmente

*/

using System;

class PracT2_E3
{
	static void Main()
	{
		int lines = 0;
		bool done = false;
		
		do
		{
			try
			{
				Console.Write("Enter the number of lines: ");
				lines = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
			if((lines % 2 != 0) && (lines >= 9) && (lines <=26))
			{
				done = true;
			}else{
				Console.WriteLine("Wrong insert");
			}
		}while(!done);
		
		for(int i=0; i<lines; i++)
		{
			for(int j=0; j<lines; j++)
			{
				if((i == 0) || (i == lines-1))
				{
					Console.Write("*");
				}
			}
			Console.WriteLine();
		}
	}
}
