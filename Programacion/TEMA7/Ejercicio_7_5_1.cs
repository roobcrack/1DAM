using System;
using System.Collections.Generic;

class Ejercicio_7_5_1{
	static void Main(){
		SortedList<string,string> miDiccio = 
			new SortedList<string,string>();
			
		miDiccio.Add("one", "uno");
		miDiccio.Add("two", "dos");
		miDiccio.Add("three", "tres");
		miDiccio.Add("four", "cuatro");
		miDiccio.Add("five", "cinco");
		miDiccio.Add("six", "seis");
		miDiccio.Add("seven", "siete");
		miDiccio.Add("eight", "ocho");
		miDiccio.Add("nine", "nueve");
		miDiccio.Add("ten", "diez");
		
		string insert;
		Console.WriteLine("Inserte numero en ingles(enter para salir)");
		do{
			Console.Write("Insert: ");
			insert = Console.ReadLine();
			
			if(miDiccio.ContainsKey(insert))
				Console.WriteLine(miDiccio[insert]+"\n");
			else if(insert!="")
				Console.WriteLine("No hay coincidencias\n");
		} while(insert != "");
		
	}
}
