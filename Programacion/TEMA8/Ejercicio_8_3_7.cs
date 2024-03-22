/*Crea un programa que pida al usuario el nombre de un fichero de texto y
muestre en orden inverso las líneas que lo forman, empleando una pila.*/
using System;
using System.IO;
using System.Collections.Generic;

class Program{
	static void Main(){
		Stack<string> pila = new Stack<string>();
		StreamReader fichero = File.OpenText("fichero.txt");
		string linea = fichero.ReadLine();
		while(linea != null){
			pila.Push(linea);
			linea = fichero.ReadLine();
		}
		fichero.Close();
		
		int count = pila.Count;
		for(int i=0; i<count; i++){
			Console.WriteLine(pila.Pop());
		}
	}
}
