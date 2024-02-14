using System;
using System.Collections.Generic;

class Ejercicio_7_4_2{
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
		
		Console.WriteLine();
		do{
			Console.Write("Inserte frase a buscar: ");
			frase = Console.ReadLine();
			for(int i=0; i<miLista.Count; i++){
				if(miLista[i].Contains(frase))
					Console.WriteLine(frase);
			}
		} while(frase != "");
	}
}
