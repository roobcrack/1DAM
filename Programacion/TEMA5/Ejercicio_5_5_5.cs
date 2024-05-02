//Ruben Martinez Martinez
/*Crea una función "SumarCifras" que reciba un numero cualquiera y que
devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera
123, la suma sería 6.*/

using System;

class Ejercicio_5_5_5{
	static void Main(){
		Console.WriteLine("Insert a number: ");
		string number = Console.ReadLine();
		
		Console.WriteLine(Sum(number));
	}
	
	static int Sum(string number){
		int total=0;
		foreach(char n in number){
			int intNumber = Int32.Parse(n);
			total =+ intNumber;
		}
		
		return total;
	}
}
