/*Crea un programa que pida un número del 1 al 10 al usuario, y escriba el
nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
programa escribirá "uno").*/

using System;

class Ejercicio_2_1_9_1
{
	static void Main()
	{
		int number;
		
		Console.Write("Enter one number between one and ten: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		switch(number)
		{
				case 1: Console.WriteLine("The number is one");
					break;
					
				case 2: Console.WriteLine("The number is two");
					break;
					
				case 3: Console.WriteLine("The number is three");
					break;
					
				case 4: Console.WriteLine("The number is four");
					break;
					
				case 5: Console.WriteLine("The number is five");
					break;
					
				case 6: Console.WriteLine("The number is six");
					break;
					
				case 7: Console.WriteLine("The number is seven");
					break;
					
				case 8: Console.WriteLine("The number is eight");
					break;
					
				case 9: Console.WriteLine("The number is nine");
					break;
					
				case 10: Console.WriteLine("The number is ten");
					break;
				
				default: 
					Console.WriteLine("The number is not between 1 and 10");
					break;
		}
	}
}
