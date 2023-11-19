/*Crea un programa que convierta una cantidad prefijada de metros (por
ejemplo, 3000) a millas. La equivalencia es 1 milla = 1609 metros. Usa comentarios
donde te parezca adecuado.*/

using System;

class Ejercicio_1_9_1
{
	static void Main()
	{
		//The number of meters
		int meters = 3000;
		
		//Calculate what 3000 meters are in miles
		Console.WriteLine("3000 meters are {0} miles", meters / 1609.0);
	}
}
