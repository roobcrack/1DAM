//Ruben Martinez Martinez

using System;

class Ejercicio_3_2_4
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++)
				{
					Console.WriteLine("{0}-Exercise 3.2.4.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_2_4_1();
					break;
				case "2": Ejercicio_3_2_4_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*Crea un programa que calcule la raíz cuadrada del número que
introduzca el usuario. La raíz se deberá calcular como "double", pero el 
resultado se mostrará como "float". (Recuerda: como viste al hacer el ejercicio 
3.2.3.3, la raíz cuadrada de un número x se calcula con Math.Sqrt(x)).*/

	static void Ejercicio_3_2_4_1()
	{
		Console.Write("Insert a number: ");
		double number = Convert.ToDouble(Console.ReadLine());
	}
	
	static void Ejercicio_3_2_4_2()
	{
		
	}
}
	
