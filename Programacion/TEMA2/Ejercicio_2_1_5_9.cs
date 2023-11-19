/*Crea un programa que pida al usuario tres números y muestre cuál es el
mayor de los tres.*/

using System;

class Ejercicio_2_1_5_9
{
	static void Main()
	{
		int number1, number2, number3;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number : ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a third number: ");
		number3 = Convert.ToInt32(Console.ReadLine());
		
		if((number1 > number2) && (number1 > number3))
		{
			Console.WriteLine("{0} is the greatest number", number1);
		}else if((number2 > number1) && (number2 > number3))
		{
			Console.WriteLine("{0} is the greatest number", number2);
		}else
		{
			Console.WriteLine("{0} is the greatest number", number3);
		}
	}
}
