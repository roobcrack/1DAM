/*Crea un programa que pida números positivos al usuario, y vaya
calculando y mostrando la suma de todos ellos (terminará cuando se teclea un
número negativo o cero).*/

using System;

class Ejercicio_2_2_2_1
{
	static void Main()
	{
		int number, total;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		total = number;
		while(number != 0)
		{
			Console.Write("Add other number: ");
			number = Convert.ToInt32(Console.ReadLine());
			
			total = number + total;
			
			Console.WriteLine();
			Console.WriteLine("Total: {0}", total);
		}
	}
}
