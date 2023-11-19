//Ruben Martinez Martinez

/*Crea un programa que pida al usuario una cantidad de kilómetros y
muestre su equivalencia en millas. El valor de conversión debe estar en una
variable definida con "var".*/

using System;

class Ejercicio_3_7_1
{
	static void Main()
	{
		Console.Write("Insert km: ");
		int km = Convert.ToInt32(Console.ReadLine());
		
		var result = km * 0.621371192;
		
		Console.WriteLine("{0} miles", result);
	}
}
