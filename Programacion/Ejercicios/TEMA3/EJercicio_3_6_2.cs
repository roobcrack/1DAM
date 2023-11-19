//Ruben Martinez Martinez

/*Crea una enumeración para los meses del año, desde ENERO (con valor 1)
hasta DICIEMBRE (con valor 12). Muestra el valor numérico correspondiente a
OCTUBRE.*/

using System;

enum months { a, January, Febrary, March, April, May, June, July, August, 
	September, October, November, December };
	
class Ejercicio_3_6_2
{
	static void Main()
	{
		Console.WriteLine((int) months.October);
	}
}
