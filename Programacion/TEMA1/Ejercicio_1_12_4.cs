/*Crea un programa que convierta de grados Celsius (centígrados) a
Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y
usará las siguiente tablas de conversión: kelvin = celsius + 273 ; fahrenheit
= celsius x 18 / 10 + 32. Emplea "Write" en vez de "{0}" cuando debas
mostrar varios datos en la misma línea.*/

using System;

class Ejercicio_1_12_4
{
	static void Main()
	{
		int celsiusDegrees, fahrenheitDegrees, kelvinDegrees;
		
		Console.Write("Enter the celsius degrees: ");
		celsiusDegrees = Convert.ToInt32(Console.ReadLine());
		
		fahrenheitDegrees = celsiusDegrees * 18 / 10;
		kelvinDegrees = celsiusDegrees + 273;
		
		Console.Write("Transformed in kelvin degrees: ");
		Console.Write(kelvinDegrees);
		Console.Write("°, in Fahrenheit degrees: ");
		Console.Write(fahrenheitDegrees);
		Console.Write("°");
	}
}
