/*Crea un programa que pida al usuario su contraseña (numérica).
Deberá terminar cuando introduzca como contraseña el número 1111, pero
volvérsela a pedir tantas veces como sea necesario.*/

using System;
class Ejercicio_2_2_1_1_1
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter the password: ");
		number = Convert.ToInt32(Console.ReadLine());
	
		while (number != 1111)
		{
			Console.WriteLine("ERROR");
			Console.WriteLine();
			Console.Write("Try again: ");
			number = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Access granted");
	}
}
