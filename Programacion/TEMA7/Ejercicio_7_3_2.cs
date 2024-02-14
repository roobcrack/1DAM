using System;
using System.Collections.Generic;

class Ejercicio_7_3_2{
	static void Main(){
		Queue<string> miCola = new Queue<string>();
		string frase = "a";
		
		Console.WriteLine("Inserte frases hasta que inserte una cadena vacia.");
		do{
			Console.Write("Inserte: ");
			frase = Console.ReadLine();
			if(frase != "")
				miCola.Enqueue(frase);
		} while(frase != "");
		
		int cantidad = miCola.Count;
		for(int i=0; i<cantidad; i++){
			Console.WriteLine(i+1+"-"+miCola.Dequeue());
		}
	}
}
