using System;
using System.Collections.Generic;

class Ejercicio_7_2_1{
	static void Main(){
		Stack<string> nombresPila = new Stack<string>();
		
		Console.WriteLine("Introduce 5 nombres");
		for(int i=0; i<5; i++){
			Console.Write("Insert: ");
			nombresPila.Push(Console.ReadLine());
		}
		
		for(int i=0; i<5; i++){
			Console.WriteLine("{0}.{1}", i+1, nombresPila.Pop());
		}
	}
}
