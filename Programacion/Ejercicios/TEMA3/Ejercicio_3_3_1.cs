//Ruben Martinez Martinez

using System;

class Ejercicio_3_3_1
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<3; i++)
				{
					Console.WriteLine("{0}-Exercise 3.3.1.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_3_1_1();
					break;
				case "2": Ejercicio_3_3_1_2();
					break;
				case "3": Ejercicio_3_3_1_3();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*Crea un programa que pida una letra al usuario y diga si se trata de una
vocal.*/

	static void Ejercicio_3_3_1_1()
	{
		Console.Write("Insert a letter: ");
		char letter = Convert.ToChar(Console.ReadLine());
		
		if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || 
			letter == 'u')
		{
			Console.WriteLine("It's a vocal");
		}else
		{
			Console.WriteLine("It's not a vocal");
		}
	}
	
	
/*Crea un programa que muestre letras alternas (una sí y una no) entre la
que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se
escribirá "aceg...".*/

	static void Ejercicio_3_3_1_2()
	{
		Console.Write("Insert a letter between a-z: ");
		char letter = Convert.ToChar(Console.ReadLine());
		
		for(char i=letter; i<='z'; i++)
		{
			if(i % 2 == 0)
			{
				Console.Write(i);
			}	
		}
	}
	
	
/*Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto
(por ejemplo, 3) y una letra (por ejemplo, X) y escriba un rectángulo formado 
por esa cantidad de letras:
XXXX
XXXX
XXXX*/

	static void Ejercicio_3_3_1_3()
	{
		Console.Write("Insert height: ");
		int height = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert width: ");
		int width= Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a character: ");
		char letter = Convert.ToChar(Console.ReadLine());
		
		for(int i=0; i<height; i++)
		{
			for(int j=0; j<width; j++)
			{
				Console.Write(letter);
			}
			Console.WriteLine();
		}
	}
}
