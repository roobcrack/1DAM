/*Crea un programa que pida al usuario dos números y escriba su máximo
común divisor (pista: una solución lenta pero sencilla es probar con un "for" 
todos los números descendiendo a partir del menor de ambos, hasta llegar a 1; 
cuando encuentres un número que sea divisor de ambos, interrumpe la búsqueda con
"break").*/

using System;

class Ejercicio_2_2_10_1
{
	static void Main()
	{
		int number1, number2, numberLower;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		numberLower = number1 > number2 ? number2 : number1;
		
		for(int i=numberLower; i>0; i--)
		{
			if((number1 % i == 0) && (number2 % i == 0))
			{
				Console.WriteLine(i);
				break;
			}
		}
	}	
}
