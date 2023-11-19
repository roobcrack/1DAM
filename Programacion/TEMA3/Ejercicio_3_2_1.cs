//Ruben Martinez Martinez

using System;

class Ejercicio_3_2_1
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++)
				{
					Console.WriteLine("{0}-Exercise 3.2.1.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_2_1_1();
					break;
				case "2": Ejercicio_3_2_1_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	

/*Crea un programa que muestre el resultado de dividir 3 entre 4, primero
usando números enteros y luego usando números de coma flotante.*/

	static void Ejercicio_3_2_1_1()
	{
		int number1, number2;
		
		Console.Write("Insert a number: ");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		number2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("With int: {0}", number1 / number2);
		
		float numberf1 = (float) number1;
		float numberf2 = (float) number2;
		
		Console.WriteLine("With float: {0}", numberf1 / numberf2);
	}
	
	
/*¿Cuál sería el resultado de las siguientes operaciones, usando números
reales? a=5; a/=2; a+=1; a*=3; --a;*/

	static void Ejercicio_3_2_1_2()
	{
		float a = 5f;
		
		Console.WriteLine(a/=2);
		Console.WriteLine(a+=1);
		Console.WriteLine(a*=3);
		Console.WriteLine(--a);
	}
}
