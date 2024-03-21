using System;
using System.IO;
using System.Collections.Generic;

class Program{
	static void Main(){
		Queue<string> cola = new Queue<string>();
		StreamReader fichero = File.OpenText("fichero.txt");
		string linea = fichero.ReadLine();
		while(linea != null){
			cola.Enqueue(linea);
			Console.WriteLine(linea);
			linea = fichero.ReadLine();
		}
		fichero.Close();

		int longitud = cola.Count;
		using(StreamWriter fichero2 = new StreamWriter("fichero2.txt")){
			for(int i=0; i<longitud; i++)
				fichero2.WriteLine(cola.Dequeue());
		}
	}
}
