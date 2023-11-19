/*rea un programa que escriba los números del 1 al 10, separados por un
espacio, sin avanzar de línea. No puedes usar "for", ni "while", ni "do..while",
sólo "if" y "goto".*/

using System;

class Ejercicio_2_2_14_1
{
	static void Main()
	{
		int number = 0;
		
		restart:
		
		number++;
		Console.WriteLine(number);
		
		if(number<10)
		{
			goto restart;
		}
	}
}
