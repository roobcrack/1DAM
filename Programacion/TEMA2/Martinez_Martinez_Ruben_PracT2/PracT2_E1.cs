/*

Martinez Martinez, Ruben
Practica Evaluable Tema 2
Ejercicio 1		si
/*
 
Martinez Martinez, Ruben
Practica Evaluable Tema 2
Ejercicio 1		si

*/

using System;

class PracT2_E1
{
	static void Main()
	{
		int monthCurrent=0, yearCurrent=0, monthBirth = 0, yearBirth = 0,
			young = 0, adult = 0, old = 0;
		string name = "a", monthLetter = "a";
		
		bool done = false;
		
		//Ask for year and month------------------------------------------------
		do
		{
			try
			{
				Console.Write("Enter atual month: ");
				monthCurrent = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine();
			}
			
			if((monthCurrent >= 1) && (monthCurrent<=12))
			{
				done = true;
			}else
			{
				Console.WriteLine("Number must be between 1-12");
				Console.WriteLine();
			}
		}while(!done);

		//Ask for the year------------------------------------------------------
		done = false;		
		do
		{
			try
			{
				Console.Write("Enter actual year: ");
				yearCurrent = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine();
			}
			
			if(yearCurrent > 1990)
			{
				done = true;
			}else
			{
				Console.WriteLine("Number must be higher than 1900");
				Console.WriteLine();
			}
		}while(!done);
		Console.WriteLine();
		
		//Program loop----------------------------------------------------------
		done = false;
		do
		{
			//Ask for the name--------------------------------------------------
			do
			{
				try
				{
					Console.Write("Enter the name of person {0}: ", young + 
						adult + old + 1);
					name = Console.ReadLine();
				}catch(Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine();
				}
				
				done = true;
			}while(!done);
			
			//Ask the month-----------------------------------------------------
			done = false;
			do
			{
				try
				{
					Console.Write("Enter the month if was born: ");
					monthBirth = Convert.ToInt32(Console.ReadLine());
				}catch(Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine();
				}
				
				if((monthBirth >= 1) && (monthBirth<=12))
				{
					done = true;
				}else
				{
					Console.WriteLine("Number must be between 1-12");
					Console.WriteLine();
			}
				
				switch(monthBirth)
				{
					case 1: monthLetter = "january"; break;
					case 2: monthLetter = "february"; break;
					case 3: monthLetter = "march"; break;
					case 4: monthLetter = "april"; break;
					case 5: monthLetter = "may"; break;
					case 6: monthLetter = "june"; break;
					case 7: monthLetter = "july"; break;
					case 8: monthLetter = "august"; break;
					case 9: monthLetter = "september"; break;
					case 10: monthLetter = "october"; break;
					case 11: monthLetter = "november"; break;
					case 12: monthLetter = "december"; break;
						
					default: Console.WriteLine("Enter a month");
						break;
				}
			}while(!done);
			
			//Ask the year------------------------------------------------------
			done = false;		
			do
			{
				try
				{
					Console.Write("Enter the year it was born: ");
					yearBirth = Convert.ToInt32(Console.ReadLine());
				}catch(Exception e)
				{
					Console.WriteLine(e.Message);
					Console.WriteLine();
				}
				
				if((yearBirth > 1900) || (yearBirth == 0))
				{
					done = true;
				}else
				{
					Console.WriteLine("Number must be higher than 1900");
				}
			}while(!done);
			if(yearBirth != 0)
			{
				int age = yearCurrent - yearBirth;
				age = monthBirth > monthCurrent ? age - 1 : age;
				
				//Print message-------------------------------------------------
				Console.WriteLine("{0} has was born in {1} of {2}, and is {3} "
					+ "years old", name, monthLetter, yearBirth, age);
			
				//Print each ages total-----------------------------------------
				if(age < 25)
				{
					young++;
				}else if(age > 49)
				{
					old++;
				}else
				{
					adult++;
				}
			}else{
				continue;
			}
			Console.WriteLine();
			
		}while(yearBirth != 0);
		
		//Print which cases are-------------------------------------------------
		Console.WriteLine();
		Console.WriteLine("There are {0} youngs, {1} adults and {2} olds", 
			young, adult, old);
		
		if(old == 0)
		{
			Console.WriteLine("There is no old people");
		}else if ((old != 0) && ((young + adult)) == 0)
		{
			Console.WriteLine("All of them are older than 50");
		}else
		{
			Console.WriteLine("There are some old people and some are not");
		}
	}
}
