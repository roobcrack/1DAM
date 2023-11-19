/*El usuario tecleará dos números (a y b), y el programa mostrará el
resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b2.
Ambos resultados se deben mostrar en la misma línea.*/

using System;

class Ejercicio_1_12_1
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter the a number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the b number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\n(a+b) * (a-b) = {0}", 
			(number1 + number2) * (number1 - number2));
			
		Console.Write("a^2 - b^2 = {0}", 
			(number1 * number1) - (number2 * number2));
	}
}
