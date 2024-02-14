using System;
using System.Collections.Generic;

class Ejercicio_7_3_1{
	static void Main(){
		Queue<double> miCola = new Queue<double>();
	
		Console.WriteLine("Inserte 5 numeros de doble precision: ");
		for(int i=0; i<5; i++){
			Console.Write(i+1+"-");
			miCola.Enqueue(Convert.ToDouble(Console.ReadLine()));
		}
		
		Console.WriteLine();
		for(int i=0; i<5; i++){
			Console.WriteLine("1-"+miCola.Dequeue());
		}
	}
}
