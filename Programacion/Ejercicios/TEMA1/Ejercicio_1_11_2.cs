//Rubén Martínez Martínez 19/9/2023 - 18:29
/*Crea una nueva versión del programa que calcula la división de dos
números introducidos por el usuario, así como el resto de esa división (1.10.2),
empleando "using System". Deberás incluir un comentario con tu nombre y la
fecha en que has realizado el programa.*/

using System;

class Ejercicio_1_11_2
{
	static void Main()
	{
		int number1, number2;
		
		Console.Write("Enter the first numbre: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter the second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nThe division of {0} and {1} is {2}",
			number1, number2, number1 / number2);
	}
}
