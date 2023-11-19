/*Pide al usuario una cantidad de "millas náuticas" y muestra la equivalencia
en metros, usando: 1 milla náutica = 1852 metros.*/

using System;

class Ejercicio_1_10_4
{
	static void Main()
	{
		int nauticalMiles, meters = 1852;
		
		Console.Write("Enter the number of nautical miles: ");
		nauticalMiles = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\n{0} nautic miles are {1} meters", 
			nauticalMiles, nauticalMiles *  meters);
	}
}
