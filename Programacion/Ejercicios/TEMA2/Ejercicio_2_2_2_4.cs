/*Crea un programa que pida al usuario su identificador y su contraseña
(ambos numéricos), y no le permita seguir hasta que introduzca como
identificador "1234" y como contraseña "1111".*/

using System;

class Ejercicio_2_2_2_4
{
	static void Main()
	{
		int input=0;
		
		while(input != 1234)
		{
			Console.Write("Enter your username: ");
			input = Convert.ToInt32(Console.ReadLine());
			
			if (input != 1234) 
			{
				Console.WriteLine("ERROR");
			}
		}
		
		while(input != 1111)
		{
			Console.Write("Enter your password: ");
			input = Convert.ToInt32(Console.ReadLine());
			
			if (input != 1111) 
			{
				Console.WriteLine("ERROR");
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Access granted");
	}
}
