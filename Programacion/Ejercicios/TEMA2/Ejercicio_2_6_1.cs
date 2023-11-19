/*Crea un programa que pregunte al usuario su edad y su año de nacimiento.
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso y
se detendrá. Lo mismo ocurrirá si el año de nacimiento no es un número válido.*/

using System;

class Ejercicio_2_6_1
{
	static void Main()
	{
		int age, birthYear;
		
		try
		{
			Console.Write("Insert your age: ");
			age = Convert.ToInt32(Console.ReadLine());
		}catch(Exception)
		{
			Console.WriteLine("Number not valid");
		}
		
		Console.Write("Insert the year you were born: ");
		birthYear = Convert.ToInt32(Console.ReadLine());
	}
}
