/*Crea un programa que pida al usuario dos números enteros y diga si el
primero es múltiplo del segundo (pista: igual que en el ejercicio 2.1.1.1, 
habrá que ver si el resto de la división es cero: a % b == 0).*/

using System;

class Ejercicio_2_1_1_3
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if(number2 % number1 == 0)
			Console.WriteLine("{0} is multiple of {1}", number1, number2);
	}
}
