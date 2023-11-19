//Ruben Martinez Martinez

using System;

class Ejercicio_3_5
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<6; i++)
				{
					Console.WriteLine("{0}-Exercise 3.5.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_5_1();
					break;
				case "2": Ejercicio_3_5_2();
					break;
				case "3": Ejercicio_3_5_3();
					break;
				case "4": Ejercicio_3_5_4();
					break;
				case "5": Ejercicio_3_5_5();
					break;
				case "6": Ejercicio_3_5_6();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*Crea un programa que use el operador condicional para dar a una variable
llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado 
el usuario son iguales, o "false" si son distintos.*/

	static void Ejercicio_3_5_1()
	{
		bool same;
		
		Console.Write("Insert one number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		same = number1 == number2;
		Console.WriteLine(same);
	}
	
	
/*Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del
operador condicional.*/

	static void Ejercicio_3_5_2()
	{
		bool same;
		
		Console.Write("Insert one number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		if(number1 == number2)
		{
			same = true;
			Console.WriteLine(same);
		}else
		{
			same = false;
			Console.WriteLine(same);
		}
	}
	
	
/*Crea una versión alternativa del ejercicio 3.5.1, que asigne directamente el
valor al booleano a partir de una comparación.*/

	static void Ejercicio_3_5_3()
	{
		bool same;
		
		Console.Write("Insert one number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		same = number1 == number2;
		Console.WriteLine(same);
	}


/*Crea un programa que use el operador condicional para dar a una variable
llamada "ambosPares" (booleana) el valor "true" si dos números introducidos por
el usuario son pares, o "false" si alguno es impar.*/

	static void Ejercicio_3_5_4()
	{
		bool bothEven;
		
		Console.Write("Insert one number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		bothEven = ((number1 % 2 == 0) && (number2 % 2 == 0));
		Console.WriteLine(bothEven);
	}
	
	
/*Crea una versión alternativa del ejercicio 3.5.4, que use "if" en vez del
operador condicional*/

	static void Ejercicio_3_5_5()
	{
		bool bothEven;
		
		Console.Write("Insert one number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		if(number1 % 2 == 0 && number2 % 2 == 0) 
		{
			bothEven = true;
			Console.WriteLine(bothEven);
		}else
		{
			bothEven = false;
			Console.WriteLine(bothEven);
		}
	}
	
	static void Ejercicio_3_5_6()
	{
		bool bothEven;
		
		Console.Write("Insert one number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Insert a second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());
		
		bothEven = ((number1 % 2 == 0) && (number2 % 2 == 0));
		Console.WriteLine(bothEven);
	}
}
