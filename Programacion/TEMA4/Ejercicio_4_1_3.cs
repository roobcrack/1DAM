//Ruben Martinez Martinez

using System;

class Ejercicio_4_1_3{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<11; i++){
					Console.WriteLine("{0}-Exercise 4.1.1.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_1_3_1();
					break;
				case "2": Ejercicio_4_1_3_2();
					break;
				case "3": Ejercicio_4_1_3_3();
					break;
				case "4": Ejercicio_4_1_3_4();
					break;
				case "5": Ejercicio_4_1_3_5();
					break;
				case "6": Ejercicio_4_1_3_6();
					break;
				case "7": Ejercicio_4_1_3_7();
					break;
				case "8": Ejercicio_4_1_3_8();
					break;
				case "9": Ejercicio_4_1_3_9();
					break;
				case "10": Ejercicio_4_1_3_10();
					break;
				case "11": Ejercicio_4_1_3_11();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
		
/*Crea un programa que pida al usuario 6 números enteros cortos y luego
los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para
mostrarlos)*/
	static void Ejercicio_4_1_3_1(){
		int[] numbers = new int[5];
		
		for(int i=0; i<5; i++){
			Console.Write("Insert real number: ");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		for(int i=4; i>=0; i--){
			Console.Write("{0} ", numbers[i]);
		}
	}
		
/*Crea un programa que pregunte al usuario cuántos números enteros va a
introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array
y finalmente calcule y muestre la media de esos números*/
	static void Ejercicio_4_1_3_2(){
		int number, average=0;
		
		Console.Write("Howe many numbers you want to enter: ");
		number = Convert.ToInt32(Console.ReadLine());
		int[] numbers = new int[number];
		
		for(int i=0; i<number; i++){
			Console.Write("Insert number: ");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
			average = average + numbers[i];
		}
		
		Console.WriteLine("The average of those numbers is: {0}", 
			average / number);
	}

/*Un programa que pida al usuario 10 reales de doble precisión, calcule su
media y luego muestre los que están por encima de la media*/	
	static void Ejercicio_4_1_3_3(){
		double[] numbers = new double[10];
		double average=0;
		
		for(int i=0; i<10; i++){
			Console.Write("Insert number real: ");
			numbers[i] = Convert.ToDouble(Console.ReadLine());
			average = average + numbers[i];
		}
		
		Console.WriteLine("These are the numbers over the average: ");
		for(int i=0; i<10; i++){
			if(numbers[i] > average / 10){
				Console.Write("{0} ", numbers[i]);
			}
		}
	}
	
/*Un programa que almacene en una tabla el número de días que tiene
cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 
para febrero) y un día (ej. el día 15) y diga qué número de día es dentro del 
año (por ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre 
sería el día 365)*/
	static void Ejercicio_4_1_3_4(){
		int[] days = {31, 28, 31, 30, 31, 30, 31, 30, 31, 31, 30, 31};
		
		Console.Write("Choose one month (in number 1-12): ");
		int month = Convert.ToInt32(Console.ReadLine());
		Console.Write("Choose a day of the month: ");
		int day = Convert.ToInt32(Console.ReadLine());
		
		int totalDay = day;
		for(int i=0; i<month-1; i++){
			totalDay = totalDay + days[i];
		}
		Console.WriteLine("{0} of {1} is day: {2}", day, month, totalDay);
	}
	
/*A partir del ejercicio anterior, crea otro que pida al usuario que le indique
la fecha, formada por día (1 al 31) y el mes (1=enero, 12=diciembre), y como
respuesta muestre en pantalla el número de días que quedan hasta final de año.*/
	static void Ejercicio_4_1_3_5(){
		int[] days = {31, 28, 31, 30, 31, 30, 31, 30, 31, 31, 30, 31};
		
		Console.Write("Choose one month (in number 1-12): ");
		int month = Convert.ToInt32(Console.ReadLine());
		Console.Write("Choose a day of the month: ");
		int day = Convert.ToInt32(Console.ReadLine());
		
		int totalDay = day;
		for(int i=0; i<month-1; i++){
			totalDay = totalDay + days[i];
		}
		Console.WriteLine("{0} of {1}, there are {2} days left to end the year",
			day, month, 365-totalDay);
	}
	
/*Un programa que pida 10 nombres y los memorice (pista: esta vez se
trata de un array de "string"). Después deberá pedir que se teclee un nombre y
dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a 
pedir otro nombre y a decir si se encuentra entre ellos, y así sucesivamente 
hasta que se teclee "fin". En el siguiente apartado verás detalles de cómo hacer
ese tipo de búsquedas*/

	static void Ejercicio_4_1_3_6(){
		string[] names = new string[10];
		string insert;
		
		for(int i=0; i<10; i++){
			Console.Write("Insert name: ");
			names[i] = Console.ReadLine();
		}
		
		do{
			Console.Write("Insert for search: ");
			insert = Console.ReadLine();
			for(int i=0; i<10; i++){
				if(names[i] == insert){
					Console.WriteLine("It's inserted");
					break;
				}
			}
		}while(insert!="end");
	}
	
/*Un programa que prepare espacio para guardar un máximo de 100
nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se
pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres
y se mostrará en pantalla la lista de los nombres que se han introducido.*/
	static void Ejercicio_4_1_3_7(){
		string[] names = new string[100];
		string insert;
		int counter=0;
		
		do{
			Console.Write("Insert name: ");
			insert = Console.ReadLine();
			names[counter] = insert;
			counter++;
		}while(insert!="");
		
		for(int i=0; i<names.Length; i++){
			Console.Write("{0} ", names[i]);
		}
	}
	
/*Un programa que reserve espacio para un vector de 3 componentes, pida
al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su
módulo (raíz cuadrada de la suma de sus componentes al cuadrado).*/
	static void Ejercicio_4_1_3_8(){
		int[] vectors = new int[3];
		int result=0;
		
		Console.WriteLine("Insert vector");
		for(int i=0; i<3; i++){
			Console.Write("Vector {0}: ", i+1);
			vectors[i] = Convert.ToInt32(Console.ReadLine());
			result = result + vectors[i];
		}
		
		Console.WriteLine("It's module is: {0}", Math.Sqrt(result));
	}

/*Un programa que reserve espacio para dos vectores de 3 componentes,
pida al usuario sus valores y calcule la suma de ambos vectores (su primera
componente será x1+y1, la segunda será x2+y2 y así sucesivamente).*/
	static void Ejercicio_4_1_3_9(){
		int[] vector1 = new int[3];
		int[] vector2 = new int[3];
		
		Console.WriteLine("Insert first vector");
		for(int i=0; i<3; i++){
			Console.Write("Vector {0}: ", i+1);
			vector1[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("Insert second vector");
		for(int i=0; i<3; i++){
			Console.Write("Vector {0}: ", i+1);
			vector2[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("The addition of both vectors is: ");
		for(int i=0; i<3; i++){
			Console.Write("{0} ", vector1[i] + vector2[i]);
		}
	}
	
/*Un programa que reserve espacio para dos vectores de 3 componentes,
pida al usuario sus valores y calcule su producto escalar (x1·y1+ x2·y2+x3·y3)*/
	static void Ejercicio_4_1_3_10(){
		int[] vector1 = new int[3];
		int[] vector2 = new int[3];
		int result = 0;
		
		Console.WriteLine("Insert first vector");
		for(int i=0; i<3; i++){
			Console.Write("Vector {0}: ", i+1);
			vector1[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("Insert second vector");
		for(int i=0; i<3; i++){
			Console.Write("Vector {0}: ", i+1);
			vector2[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("Its product is: ");
		for(int i=0; i<3; i++){
			result = result + (vector1[i] * vector2[i]);
		}
		Console.WriteLine("The porudc is: {0}", result);
	}
	
/*Un programa que pida al usuario 4 números enteros y calcule (y
muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un 
array, hay que comparar cada uno de los valores que tiene almacenados el array 
con el que hasta ese momento es el máximo provisional. El valor inicial de este 
máximo provisional no debería ser cero (porque el resultado sería incorrecto si 
todos los números son negativos), sino el primer elemento del array*/
	static void Ejercicio_4_1_3_11(){
		int[] numbers = new int[4];
		
		for(int i=0; i<4; i++){
			Console.Write("Insert number: ");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		}
		int maxNumber = numbers[0];
		
		for(int i=1; i<4; i++){
			maxNumber = numbers[i] > maxNumber ? numbers[i] : maxNumber;
		}
		Console.WriteLine("Max number is: {0}", maxNumber);
	}
}
