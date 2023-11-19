/*Crea un programa en el que el usuario deba adivinar un número del 1 al
100 (prefijado en el programa). En cada pasada deberá avisar de si se ha pasado
o se ha quedado corto.*/

using System;

class Ejercicio_2_5_2
{
	static void Main()
	{
		int numberCorrect = 78, userInsert;
		
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
		}while(userInsert != numberCorrect);
		
		Console.WriteLine("You guessed the number");
	}
}
