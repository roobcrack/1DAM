/*Crea un programa que pida al usuario dos números y escriba sus
divisores comunes. Debes usar llaves en todas las estructuras de control, aunque
sólo incluyan una sentencia*/

using System;

class Ejercicio_2_2_9_1
{
	static void Main()
	{
		int number1, number2, numberHigher;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		numberHigher = number1 > number2 ? number1 : number2;
		
		for(int i=1; i<=numberHigher; i++)
		{
			if((number1 % i == 0) && (number2 % i == 0))
			{
				Console.WriteLine(i);
			}
		}
	}
}
