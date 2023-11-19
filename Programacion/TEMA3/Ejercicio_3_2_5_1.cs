//Ruben Martinez Martinez

using System;

class Ejercicio_3_2_5
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<4; i++)
				{
					Console.WriteLine("{0}-Exercise 3.2.5.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_2_5_1();
					break;
				case "2": Ejercicio_3_2_5_2();
					break;
				case "3": Ejercicio_3_2_5_3();
					break;
				case "4": Ejercicio_3_2_5_4();
					break;
				case "5": Ejercicio_3_2_5_5();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*El usuario de nuestro programa podrá teclear dos números de hasta 12
cifras significativas. El programa deberá mostrar el resultado de dividir el
primer número entre el segundo, utilizando tres cifras decimales.*/

	static void Ejercicio_3_2_5_1()
	{
		
	}
	
	static void Ejercicio_3_2_5_2()
	{
		
	}
	
	static void Ejercicio_3_2_5_3()
	{
		
	}
	
	static void Ejercicio_3_2_5_4()
	{
		
	}
	
	static void Ejercicio_3_2_5_5()
	{
		
	}
}
