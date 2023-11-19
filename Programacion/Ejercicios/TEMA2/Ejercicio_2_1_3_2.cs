/*Crea un programa que pida al usuario dos números enteros. Si el
segundo no es cero, mostrará el resultado de dividir el primero entre el 
segundo. Por el contrario, si el segundo número es cero, escribirá 
"Error: No se puede dividir entre cero".*/

using System;

class Ejercicio_2_1_3_2
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		if(number2 == 0)
		{
			Console.WriteLine("You can't divide by 0");
		}
		
		if(number2 != 0)
		{
			Console.WriteLine("{0} / {1} = {2}", 
				number1, number2, number1 / number2);
		}
	}
}
