/*Haz un programa que dé al usuario la oportunidad de adivinar un número
del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. En cada
pasada deberá avisar de si se ha pasado o se ha quedado corto.*/

using System;

class Ejercicio_2_5_3
{
	static void Main()
	{
		int numberCorrect = 78, userInsert, counter = 6;
		
		do
		{
			Console.Write("Insert a number: ");
			userInsert = Convert.ToInt32(Console.ReadLine());
			
			if(userInsert > numberCorrect)
			{
				Console.WriteLine("Number is smaller");
			}else if(userInsert < numberCorrect)
			{
				Console.WriteLine("Number is bigger");
			}
			
			if(userInsert != numberCorrect)
			{
				counter--;
				Console.WriteLine("You have {0} attemps left", counter);
			}

		}while(counter > 0);
		
		if(counter != 0)
		{
			Console.WriteLine("You guessed the number");
		}
	}
}
