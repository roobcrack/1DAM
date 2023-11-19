/*Crea un programa que muestre una cuenta atrás (3 2 1 0) desde el número
que introduzca el usuario hasta cero. Ese número debe estar entre 1 y 10 (y el
programa debe comprobar que realmente lo está, y volverlo a pedir tantas veces
como sea necesario, en caso de que no sea así).*/

using System;

class Ejercicio_2_5_1
{
	static void Main()
	{
		int number;
		
		do
		{
			Console.WriteLine("Enter one number between 1 and 10");
			number = Convert.ToInt32(Console.ReadLine());
		}while(number < 0 && number > 10);
		
		for(int i=number; i>0; i--)
		{
			Console.WriteLine(number);
			number--;
		}
	}
}
