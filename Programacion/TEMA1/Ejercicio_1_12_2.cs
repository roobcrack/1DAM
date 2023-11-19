/*Pide al usuario un número y muestra su tabla de multiplicar,
usando {0},{1} y {2}. Por ejemplo, si el número es el 3, debería escribirse
algo como
3 x 0 = 0
3 x 1 = 3
3 x 2 = 6
…
3 x 10 = 30*/

using System;

class Ejercicio_1_12_2
{
	static void Main()
	{
		int number, counter = 0;
		
		Console.Write("Enter the number you want to operate with: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine();
		
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
		Console.WriteLine("{0} x {1} = {2}", 
			number, counter, number * counter);
		counter = counter + 1;
	}
}
