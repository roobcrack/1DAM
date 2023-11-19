//Ruben Martinez Martinez

using System;

class Ejercicio_3_2_6
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<4; i++)
				{
					Console.WriteLine("{0}-Exercise 3.2.6.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_2_6_1();
					break;
				case "2": Ejercicio_3_2_6_2();
					break;
				case "3": Ejercicio_3_2_6_3();
					break;
				case "4": Ejercicio_3_2_6_4();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*Crea un programa que pida números (en base 10) al usuario y muestre su
equivalente en sistema binario y en hexadecimal. Debe repetirse hasta que el
usuario introduzca el número 0.*/

	static void Ejercicio_3_2_6_1()
	{
		int number;
		
		do
		{
			Console.Write("Insert a number: ");
			number = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("In base 2: {0}", Convert.ToString(number, 2));
			Console.WriteLine("In base 16: {0}", Convert.ToString(number, 16));
		}while(number != 0);
		
	}
	
	
/*Crea un programa que pida al usuario la cantidad de rojo (por ejemplo,
255), verde (por ejemplo, 160) y azul (por ejemplo, 0) que tiene un color, y que
muestre ese color RGB en notación hexadecimal (por ejemplo, FFA000).*/

	static void Ejercicio_3_2_6_2()
	{
		Console.Write("Insert red: ");
		int red = Convert.ToInt32(Console.ReadLine());
		Console.Write("Insert green: ");
		int green = Convert.ToInt32(Console.ReadLine());
		Console.Write("Insert blue: ");
		int blue = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Your color is: {0}", Convert.ToString(red, 16) + 
			Convert.ToString(green, 16) + Convert.ToString(blue, 16));
	}
	
	
/*Crea un programa para mostrar los números del 0 a 255 en hexadecimal,
en 16 filas de 16 columnas cada una (la primera fila contendrá los números del
0 al 15 –decimal-, la segunda del 16 al 31 –decimal- y así sucesivamente).*/

	static void Ejercicio_3_2_6_3()
	{
		for(int i=1; i<=255; i++)
		{
			Console.Write("{0} ", Convert.ToString(i, 16));
			
			if(i % 16 == 0)
			{
				Console.WriteLine();
			}
		}
	}
	
	
/*Crea un programa que pida números binarios al usuario y muestre su
equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que el
usuario introduzca la palabra "fin"*/

	static void Ejercicio_3_2_6_4()
	{
		while(true)
		{
			Console.Write("Insert the number in base 2 (end to exit): ");
			string insert = Console.ReadLine();
			
			if(insert=="end"){ break; }
			
			Console.WriteLine("Base 10: {0}", 
				Convert.ToString(Int32.Parse(insert), 10));
			Console.WriteLine("Base 16: {0}", 
				Convert.ToString(Int32.Parse(insert), 16));
		}
	}
}
