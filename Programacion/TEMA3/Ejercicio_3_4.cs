//Ruben Martinez Martinez

using System;

class Ejercicio_3_4
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++)
				{
					Console.WriteLine("{0}-Exercise 3.4.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_4_1();
					break;
				case "2": Ejercicio_3_4_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	

/*Crea un programa que pida al usuario su nombre, y le diga "Hola" si se
llama "Juan", o bien le diga "No te conozco" si teclea otro nombre.*/

	static void Ejercicio_3_4_1()
	{
		Console.Write("Insert your name: ");
		string name = Console.ReadLine();
		
		if(name == "Juan")
		{
			Console.WriteLine("Hello, Juan");
		}else
		{
			Console.WriteLine("I don't know you");
		}
	}	
	
	
/*Crea un programa que pida al usuario un nombre y una contraseña. La
contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales,
se avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces
como sea necesario hasta que coincidan.*/

	static void Ejercicio_3_4_2()
	{
		Console.Write("Username: ");
		string user = Console.ReadLine();
		
		while(true)
		{
			Console.Write("Password: ");
			string password1 = Console.ReadLine();
			
			Console.Write("Password again: ");
			string password2 = Console.ReadLine();
			
			if(password1 == password2)
			{
				Console.WriteLine("{0}, acces granted.", user);
				break;
			}else
			{
				Console.WriteLine("Password is not the same");
			}
		}
	}
}
