/*Crea un programa que pida al usuario el nombre de un fichero de texto y
una frase a buscar, y que muestre en pantalla todas las líneas de ese fichero que
contengan esa frase. Cada frase se debe preceder del número de línea (la primera
línea del fichero será la 1, la segunda será la 2, y así sucesivamente). Al final de la
lectura se debe avisar, en caso de que no se haya encontrado el texto buscado.*/

using System;
using System.IO;

class Program{
	static void Main(){
		Console.Write("Inserte el nombre del fichero: ");
		string nombreFichero = Console.ReadLine();
		Console.Write("Frase a buscar: ");
		string frase = Console.ReadLine();

		StreamReader fichero;
		string linea;
		int contador = 0;
		int coincidencias = 0;
		try{
			fichero = File.OpenText(nombreFichero+".txt");
			linea = fichero.ReadLine();

			while(linea != null){
				contador++;
				if(linea.Contains(frase)){
					coincidencias++;
					Console.WriteLine(contador+"."+linea);
				}
				linea = fichero.ReadLine();
			}
			fichero.Close();
			if(coincidencias == 0)
				Console.WriteLine("No ha sido encontrada");
		} catch(Exception e){
			Console.WriteLine(e.Message);
		}
	}
}
