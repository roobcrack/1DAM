/*Crea un programa que pida un número al usuario y diga si es primo
(divisible sólo entre 1 y él mismo).*/

using System;

class Ejercicio_2_5_4
{
	static void Main()
	{
		int number = 1;
		
		Console.Write("Insert a number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		for(int i=2; i<number; i++)
		{
			if(number % i == 0)
			{
				number = 1;
			}
		}
		
		if(number == 1)
		{
			Console.WriteLine("Is not a prime number");
		}else
		{
			Console.WriteLine("Is a prime number");
		}
	}
}
