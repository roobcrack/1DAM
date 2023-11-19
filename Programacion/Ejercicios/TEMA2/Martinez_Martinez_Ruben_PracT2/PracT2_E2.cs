/*

Martinez Martinez, Ruben
Practica Evaluable Tema 2
Ejercicio 2		parcialmente

*/

using System;

class PracT2_E2
{
	static void Main()
	{
		int number = 0, maxNumber = 0, minNumber = 999999, lastNumber = 0, 
			counter = 0, higherCounter = 0, saveNumber = 0;
		
		do
		{
			try
			{
				Console.Write("Insert a number: ");
				number = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			
			if(number != 0)
			{
				//Check higher/lower number-------------------------------------
				maxNumber = number > maxNumber ? number : maxNumber;
				minNumber = number < minNumber ? number : minNumber;
			}
			
			//Check repeat------------------------------------------------------
			if(lastNumber != number)
			{
				if(counter > higherCounter)
				{
					saveNumber = number;
					higherCounter = counter;
				}
				lastNumber = number;
				counter = 0;
			}else
			{
				counter++;
			}
			
			lastNumber = number;
		}while(number != 0);
		
		Console.WriteLine("Max number: {0}", maxNumber);
		Console.WriteLine("Min number: {0}", minNumber);
		Console.WriteLine("Most repeated number: {0}, {1} times", 
			saveNumber, higherCounter);
	}
}
