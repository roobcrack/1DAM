//Ruben Martinez Martinez

using System;

class Ejercicio_3_1_2
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<3; i++)
				{
					Console.WriteLine("{0}-Exercise 3.1.2.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_1_2_1();
					break;
				case "2": Ejercicio_3_1_2_2();
					break;
				case "3": Ejercicio_3_1_2_3();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*Pregunta al usuario su edad, que se guardará en un "byte". A
continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No
aparentas 20 años").*/

	static void Ejercicio_3_1_2_1()
	{
		byte age;
		
		Console.Write("Insert your age: ");
		age = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("You don't look like {0}", age);
	}
	
	
/*Pide al usuario dos números de dos cifras ("byte"), calcula su
multiplicación, que se deberá guardar en un "int", y muestra el resultado en
pantalla.*/

	static void Ejercicio_3_1_2_2()
	{
		byte number1, number2;
		
		Console.Write("Insert a number of 2 digits: ");
		number1 = Convert.ToByte(Console.ReadLine());
		
		Console.Write("Insert other number of 2 digits: ");
		number2 = Convert.ToByte(Console.ReadLine());
		
		int result = number1 * number2;
		Console.WriteLine("{0} * {1} = {2}", number1, number2, result);
	}
	
	
/*Pide al usuario dos números enteros largos ("long") y muestra su suma,
su resta y su producto.*/
	
	static void Ejercicio_3_1_2_3()
	{
		long number1, number2;
		
		Console.Write("Insert a long number: ");
		number1 = Convert.ToInt64(Console.ReadLine());
		
		Console.Write("Insert a long number: ");
		number2 = Convert.ToInt64(Console.ReadLine());
		
		long sum = number1 + number2;
		Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
		
		long subtraction = number1 - number2;
		Console.WriteLine("{0} - {1} = {2}", number1, number2, subtraction);
		
		long product = number1 * number2;
		Console.WriteLine("{0} * {1} = {2}", number1, number2, product);
	}
}
