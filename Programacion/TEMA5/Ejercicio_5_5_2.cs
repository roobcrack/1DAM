//Ruben Martinez Martinez
/*Crea una función "EscribirTablaMultiplicar", que reciba como parámetro un
número entero, y escriba la tabla de multiplicar de ese número (por ejemplo,
para el 3 deberá llegar desde "3x0=0" hasta "3x10=30").*/

using System;

class Ejercicio_5_5_2{
	static void Main(){
		Console.Write("Insert a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		MultiplicationTable(number);
	}
	
	static void MultiplicationTable(int number){
		for(int i=0; i<10; i++){
			Console.WriteLine("{0} * {1} = {2}", number, i+1, number * (i+1));
		}
	}
}
