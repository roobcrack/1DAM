/*Crea un programa que descomponga un número (que teclee el usuario)
como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5 (pista: 
como primera aproximación, puedes escribir siempre un "punto" después de cada
número y luego terminar con la cifra uno, así: 60 = 2 · 2 · 3 · 5 · 1; cuando 
lo consigas, piensa cómo harías para eliminar ese "• 1" del final).*/

using System;

class Ejercicio_2_5_5
{
	static void Main()
	{
		int number;
		
		Console.Write("Insert a number: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		while(number > 1)
		{
			for(int i=2; i<number; i++)
			{
				if(number % i == 0)
				{
					Console.Write(i);
					break;
				}
			}
		}
	}
}
