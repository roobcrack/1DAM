/*Crea un programa que multiplique dos números enteros de la siguiente
forma: pedirá al usuario un primer número entero. Si el número que se que teclee
es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se 
ha tecleado un número distinto de cero, se pedirá al usuario un segundo número 
y se mostrará el producto de ambos.*/

using System;

class Ejercicio_2_1_3_1
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter one number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		if(number1 == 0)
		{
			Console.WriteLine("Any product of 0 is 0");
		}
		
		if(number1 != 0)
		{
			Console.Write("Enter a second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("The product of {0} * {1} = {2}", 
				number1, number2, number1 * number2);
		}
	}
}
