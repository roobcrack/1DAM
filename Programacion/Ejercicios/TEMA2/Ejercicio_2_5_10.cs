/* Crea un programa que "dibuje" un cuadrado formado por cifras sucesivas,
con el tamaño que indique el usuario, hasta un máximo de 9. Por ejemplo, si
desea tamaño 5, el cuadrado sería así:
11111
22222
33333
44444
55555
*/

using System;

class Ejercicio_2_5_10
{
	static void Main()
	{
		int length, number;
		
		while(true){
		Console.Write("Insert how many numbers: ");
			number = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Insert the length: ");
			length = Convert.ToInt32(Console.ReadLine());
			
			if(number > 0 && number < 10 && length > 0 && length < 10)
			{
				for(int i=0; i<number; i++)
				{
					for(int j=0; j<length; j++)
					{
						Console.Write(i+1);
					}
					Console.WriteLine();
				}
				break;
			}else
			{
				Console.WriteLine("Insert numbers between 1 and 9");
			}	
		}
	}
}
