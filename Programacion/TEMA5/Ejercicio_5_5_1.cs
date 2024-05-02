//Ruben Martinez Martinez
/*Crea una función "PedirEntero", que reciba como parámetros el texto que
se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo
aceptable. Esta función deberá pedir al usuario que introduzca el valor, tantas
veces como sea necesario, deberá volvérselo a pedir en caso de error, y deberá
devolver un valor correcto. Pruébalo con un programa que pida al usuario un año
entre 1800 y 2100.*/

using System;

class Ejercicio_5_5_1{
	static void Main(){
		string text="Insert a year between 2100 and 1800";
		int maxYear=2100, minYear=1800;
		
		AskForInteger(text, minYear, maxYear);
	}
	
	static void AskForInteger(string text, int minYear, int maxYear){
		bool done=false;
		
		while(!done){
			try{
				Console.WriteLine(text);
				Console.Write("Insert: ");
				int year = Convert.ToInt32(Console.ReadLine());
				if(year < minYear || year > maxYear){
					throw new Exception("Number must be in the parameters");
				} else{
					done=true;
				}
			} catch(Exception e){ Console.WriteLine(e.Message); }
		}
	}
}
