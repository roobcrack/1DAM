using System;
using System.Collections.Generic;

class Ejercicio_7_4_3{
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
		
		miLista.Sort();
		Console.WriteLine();
		for(int i=0; i<miLista.Count; i++){
			Console.WriteLine(miLista[i]);
		}
	}
}
