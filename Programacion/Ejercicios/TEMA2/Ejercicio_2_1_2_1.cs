/*Crea un programa que pida al usuario un número entero. Si es múltiplo
de 10, informará al usuario y pedirá un segundo número, para decir a
continuación si este segundo número también es múltiplo de 10.*/

using System;

class Ejercicio_2_1_2_1
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		if(number % 10 == 0)
		{
			Console.WriteLine("{0} is multiple of 10", number);
			Console.WriteLine();
			
			Console.Write("Enter a second number: ");
			number = Convert.ToInt32(Console.ReadLine());
			
			if(number % 10 == 0)
			{
				Console.WriteLine("{0} is multiple of 10", number);
			}
		}
	}
}
