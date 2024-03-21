/*Crea un programa que lea el contenido de un fichero de texto, lo almacene
línea por línea en un ArrayList, y luego pregunte de forma repetitiva al usuario qué
línea desea ver y la muestre en pantalla. Terminará cuando el usuario introduzca
el número de línea "-1".*/
using System;
using System.IO;
using System.Collections.Generic;

class Program{
	static void Main(){
		List<string> lista = new List<string>();
		StreamReader fichero = File.OpenText("fichero.txt");
		
		string linea = fichero.ReadLine();
		while(linea != null){
			lista.Add(linea);
		}
		fichero.Close();
		
		int opcion = 0;
		do{
			try{
				opcion = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(lista[opcion]);
			} catch(Exception e){
				Console.WriteLine(e.Message);
			}
		} while(opcion != -1);
	}
}
