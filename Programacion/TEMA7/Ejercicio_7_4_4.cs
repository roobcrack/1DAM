using System;
using System.Collections.Generic;

class Ejercicio_7_4_4{
	static void Main(){
		List<string> miLista = new List<string>();
		string frase = "a";
		int count = 1;
		
		Console.WriteLine("Inserte frases en el documento: ");
		do{
			Console.Write(count+++": ");
			frase = Console.ReadLine();
			if(frase != "")
				miLista.Add(frase);
		} while(frase != "");
		
		Console.WriteLine("Impares");
		for(int i=0; i<miLista.Count; i++){
			if(i%2==0)
				Console.WriteLine(miLista[i]);
		}
		
		Console.WriteLine("Pares");
		for(int i=0; i<miLista.Count; i++){
			if(i%2!=0)
				Console.WriteLine(miLista[i]);
		}
	}
}
