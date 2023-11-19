/*Crea una nueva versión del programa que calcula el producto de dos
números introducidos por el usuario (1.10.1), empleando "using System". El
programa deberá contener un comentario al principio, que recuerde cual es su
objetivo.*/

using System;

class Ejercicio_1_11_1
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter the first numbre: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nThe product of {0} and {1} is {2}",
			number1, number2, number1 * number2);
	}
}
