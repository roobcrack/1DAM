/*Crea un programa que devuelva el cambio de una compra, utilizando
monedas (o billetes) del mayor valor posible. Supondremos que tenemos una
cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay
decimales. La ejecución podría ser algo como:
Precio? 44
Pagado? 100
Su cambio es de 56: 50 5 1
Precio? 1
Pagado? 100
Su cambio es de 99: 50 20 20 5 2 2
*/

using System;

class Ejercicio_2_5_9
{
	static void Main()
	{
		int price, paid;
		
		Console.Write("Price: ");
		price = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Paid: ");
		paid = Convert.ToInt32(Console.ReadLine());
		
		int change = paid - price;
		Console.Write("The change is {0}: ", change);
		
		for(int i=0; i<7; i++)
		{
			int bills=0;
			
			switch(i)
			{
				case 0: bills = 100; break;
				case 1: bills = 50; break;
				case 2: bills = 20; break;
				case 3: bills = 10; break;
				case 4: bills = 5; break;
				case 5: bills = 2; break;
				case 6: bills = 1; break;
				default: Console.Write("Error"); break;
			} 	
			
			while(change >= bills)
			{
				change = change - bills;
				Console.Write("{0} ", bills);
			}
		}
	}
}
