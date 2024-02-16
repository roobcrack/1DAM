using System;
using System.Collections.Generic;

class Ejercicio_7_5_2{
	static void Main(){
		SortedList<string,string> miDiccio = 
			new SortedList<string,string>();
			
		miDiccio.Add("enero", "january");
		miDiccio.Add("febrero", "february");
		miDiccio.Add("marzo", "march");
		miDiccio.Add("abril", "april");
		miDiccio.Add("mayo", "may");
		miDiccio.Add("junio", "june");
		miDiccio.Add("julio", "july");
		miDiccio.Add("agosto", "august");
		miDiccio.Add("septiembre", "september");
		miDiccio.Add("octubre", "october");
		miDiccio.Add("noviembre", "november");
		miDiccio.Add("diciembre", "december");
		
		string insert;
		Console.WriteLine("Inserte un mes(enter para salir)");
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
