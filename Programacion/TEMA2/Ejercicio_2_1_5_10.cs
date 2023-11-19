/*Crea un programa que pida al usuario dos números enteros y diga si son
iguales o, en caso contrario, cuál es el mayor de ellos.*/

using System;

class Ejercicio_2_1_5_10
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if(number1 == number2)
		{
			Console.WriteLine("They are the same number");
		}else if(number1 > number2)
		{
			Console.WriteLine("{0} is greater than {1}", number1, number2);
		}else
		{
			Console.WriteLine("{0} is greater than {1}", number2, number1);
		}
	}
}
