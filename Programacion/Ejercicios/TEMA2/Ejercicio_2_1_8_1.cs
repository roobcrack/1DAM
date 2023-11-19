/*Crea un programa que use el operador condicional para mostrar el valor
absoluto de un número de la siguiente forma: si el número es positivo, se
mostrará tal cual; si es negativo, se mostrará cambiado de signo.*/

using System;

class Ejercicio_2_1_8_1
{
	static void Main()
	{
		int number, result;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		result = number > 0 ? number : number*-1;
		
		Console.WriteLine("The number possitive: {0}", result);
	}
}
