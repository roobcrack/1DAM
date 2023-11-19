/*Crea un programa que pida al usuario dos números y escriba su mínimo
común múltiplo (pista: una solución lenta pero sencilla es probar con un "for"
todos los números a partir del mayor de ambos, de forma creciente; cuando
encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda con
"break").*/

using System;

class Ejercicio_2_2_10_2
{
	static void Main()
	{
		int number1, number2, numberHigher;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		numberHigher = number1 > number2 ? number1 : number2;
		
		for(int i=0; i<numberHigher; i++)
		{
			if((i % number1 == 0) && (i % number2 == 0))
			{
				Console.WriteLine(i);
			}
		}
	}
}
