/*Crea un programa que pregunte al usuario su edad y su año de nacimiento.
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso,
pero aun así le preguntará su año de nacimiento.*/

using System;

class Ejercicio_2_6_2
{
	static void Main()
	{
		int age, birthYear;
		
		try
		{
			Console.Write("Insert your age: ");
			age = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Insert the year you were born: ");
			birthYear = Convert.ToInt32(Console.ReadLine());
		}catch(Exception)
		{
			Console.WriteLine("Number not valid");
		}
	}
}
