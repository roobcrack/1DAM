/*Crea un programa que muestre las letras de la Z (mayúscula) a la A
(mayúscula, descendiendo).*/

using System;

class Ejercicio_2_2_7_1
{
	static void Main()
	{
		for(char letter='Z'; letter>='A'; letter--)
		{
			Console.Write(letter);
		}	
	}
}
