//Ruben Martinez Martinez

using System;

class Ejercicio_3_2_3
{
	static void Main()
	{
		string number;

		while(true)
		{
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<7; i++)
				{
					Console.WriteLine("{0}-Exercise 3.2.3.{0}", i+1);
				}
				number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number)
			{
				case "1": Ejercicio_3_2_3_1();
					break;
				case "2": Ejercicio_3_2_3_2();
					break;
				case "3": Ejercicio_3_2_3_3();
					break;
				case "4": Ejercicio_3_2_3_4();
					break;
				case "5": Ejercicio_3_2_3_5();
					break;
				case "6": Ejercicio_3_2_3_6();
					break;
				case "7": Ejercicio_3_2_3_7();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}

			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}


/*Calcula el volumen de una esfera, dado su radio, que será un número de
doble precisión (volumen = pi * radio al cubo * 4/3)*/

	static void Ejercicio_3_2_3_1()
	{
		double pi = 3.141592653589793238, radius;
		
		Console.Write("Enter the radius of the sphere in cm: ");
		radius = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Radius = {0}cm", pi * radius * (4/3));
	}
	
	
/*Crea un programa que pida al usuario a una distancia (en metros) y el
tiempo necesario para recorrerla (como tres números: horas, minutos, segundos),
y muestre la velocidad, en metros por segundo, en kilómetros por hora y en 
millas por hora (pista: 1 milla = 1.609 metros).*/

	static void Ejercicio_3_2_3_2()
	{
		int meters, hours, minutes, seconds;
		
		Console.Write("Insert distance in meters: ");
		meters = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Now insert the time you need to go through it: ");
		Console.Write("Hours: ");
		hours = Convert.ToInt32(Console.ReadLine());
		Console.Write("Minutes: ");
		minutes = Convert.ToInt32(Console.ReadLine());
		Console.Write("Seconds: ");
		seconds = Convert.ToInt32(Console.ReadLine());
		
		//------------------------------------------------------
		float result = (float) meters / ((hours * 3600) + (minutes * 60)
			+ seconds);
		Console.WriteLine("In meters/second = {0}", result);
		
		//------------------------------------------------------
		result = ((float) meters / 1000) / ((hours) + ((float) minutes / 60)
			+ (float) seconds / 3600);
		Console.WriteLine("In kilometers/hour = {0}", result);
		 
		//------------------------------------------------------
		result = ((float) meters / (float) 1.609) / ((hours) + 
			((float) minutes / 60) + (float) seconds / 3600);
		Console.WriteLine("In miles/hour = {0}", result);
	}


/*Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2 +
Bx + C. Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)*/

	static void Ejercicio_3_2_3_3()
	{
		double a, b, c, result;
		
		Console.WriteLine("Now insert the three numbers of the equation: ");
		Console.Write("a: ");
		a = Convert.ToDouble(Console.ReadLine());
		Console.Write("b: ");
		b = Convert.ToDouble(Console.ReadLine());
		Console.Write("c: ");
		c = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("{0}x^2 + {1}x + {2} can be: ", a, b, c);
		result = ((-b) + Math.Sqrt((b*b) + (-4*a*c))) / (2*a);
		Console.WriteLine(result);
		result = ((-b) - Math.Sqrt((b*b) + (-4*a*c))) / (2*a);
		Console.WriteLine(result);
	}
	

/*Si se ingresan E euros en el banco a un cierto interés I durante N años, el
dinero obtenido viene dado por la fórmula del interés compuesto: Resultado = e
(1+ i)n Aplícalo para calcular en cuanto se convierten 1.000 euros al cabo de 10
años al 3% de interés anual.*/

	static void Ejercicio_3_2_3_4()
	{
		int euros, interest, years;
		
		Console.WriteLine("Let's calculate the compound interest: ");
		Console.Write("Euros: ");
		euros = Convert.ToInt32(Console.ReadLine());
		Console.Write("Interest: ");
		interest = Convert.ToInt32(Console.ReadLine());
		Console.Write("Years: ");
		years = Convert.ToInt32(Console.ReadLine());
		
		double result = euros * Math.Pow((1 + interest), years);
		Console.WriteLine("The compound interest is: {0} euros", result);
	}
	

/*Crea un programa que muestre los primeros 20 valores de la función y =
x2 - 1*/

	static void Ejercicio_3_2_3_5()
	{
		for(int i=1; i<=20; i++)
		{
			Console.WriteLine("{0}^2 - 1 = {1}", i, (i*i)-1);
		}
	}
	

/*Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x
entre 1 y 10. Deberá hacerlo dibujando varios espacios en pantalla y luego un
asterisco. La cantidad de espacios dependerá del valor obtenido para "y". Te 
será fácil si dibujas la gráfica "girada", de forma que los valores de "y" 
crezcan hacia la derecha*/

	static void Ejercicio_3_2_3_6()
	{
		for(int i=1; i<=10; i++)
		{
			int y = ((i-5) * 2);
			if(y < 0) { y = y * -1; }
			
			for(int j=0; j<y; j++)
			{
				Console.Write(" ");
			}
			Console.Write(" *");
			Console.WriteLine();
		}
	}
	
	
/*Escribe un programa que calcule una aproximación de PI mediante la
expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... El usuario 
deberá indicar la cantidad de términos a utilizar, y el programa mostrará todos
los resultados hasta esa cantidad de términos. Debes hacer todas las operaciones
con "double".*/

	static void Ejercicio_3_2_3_7()
	{
		Console.Write("To calculate pi, enter how many terms you want: ");
		double number = Convert.ToDouble(Console.ReadLine());
		
		for(double i=1; i<number; i++)
		{
			double result = 1 / (double) i;
			Console.WriteLine("1/{0} = {|}", i, result);
		}
	}
}
