/*Crea un programa que pida al usuario su identificador y su contraseña, y
no le permita seguir hasta que introduzca como nombre "Pedro" y como
contraseña "Peter".*/

using System;

class Ejercicio_2_2_2_5
{
	static void Main()
	{
		string input;
		
		do
		{
			Console.Write("Enter your username: ");
			input = Console.ReadLine();
			
			if (input != "Pedro") 
			{
				Console.WriteLine("ERROR");
			}
		}while(input != "Pedro");
		
		do
		{
			Console.Write("Enter your password: ");
			input = Console.ReadLine();
			
			if (input != "Peter") 
			{
				Console.WriteLine("ERROR");
			}
		}while(input != "Peter");
		
		Console.WriteLine();
		Console.WriteLine("Access granted");
	}
}
