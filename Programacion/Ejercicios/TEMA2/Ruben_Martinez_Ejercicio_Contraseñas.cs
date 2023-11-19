/*Crea un programa qque pida una contraseña y tenga hasta 4 intentos de acceder.
Si acierta antes de 4 intentos accede y si falla imprime mensaje con intentos
restantes*/ //Contraseña: abcd

using System;

class Ejercicio_contraseña
{
	static void Main()
	{
		string insert;
		int counter = 4, exit = 0;
		
		while(exit == 0)
		{	
			counter = counter - 1;
			
			Console.Write("Enter the password: ");
			insert = Console.ReadLine();
			
			if(insert == "abcd")
			{
				exit = 1;
			}else
			{
				Console.WriteLine("Wrong password");
				Console.WriteLine("You have {0} more tries", counter);
			}
			
			if(counter == 0)
			{
				exit = 1;
			}
			
			Console.WriteLine();
		}
		
		if(counter == 0)
		{
			Console.WriteLine("Access denied");
		}else
		{
			Console.WriteLine("Access granted");
		}
	}
}
