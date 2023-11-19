/*Crea un programa que pida al usuario un número entero y diga si es par
(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es 
cero: if (x % 2 == 0) …).*/

using System;

class Ejercicio_2_1_1_1
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter one number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		if (number % 2 == 0){
			Console.WriteLine("The number is even");
		}
	}
}
