using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SortedList<string, string> traductor = new SortedList<string, string>();
        
		traductor.Add("{","begin");
		traductor.Add("}","end");
		traductor.Add("WriteLine","WriteLn");
		traductor.Add("ReadLine","ReadLn");
		traductor.Add("void","procedure");
		traductor.Add("Console.","");

        Console.WriteLine("Por favor, ingrese el código fuente en C#:");
        string codigoCSharp = Console.ReadLine();

        string[] lineas = codigoCSharp.Split('\n');
        string codigoPascal = TraducirCodigo(lineas, traductor);

        Console.WriteLine("\nCódigo traducido a Pascal:");
        Console.WriteLine(codigoPascal);
    }

    static string TraducirCodigo(string[] lineas, SortedList<string, string> traductor)
    {
        string codigoTraducido = "";

        foreach (string linea in lineas)
        {
            string lineaTraducida = TraducirLinea(linea, traductor);
            codigoTraducido += lineaTraducida + "\n";
        }

        return codigoTraducido;
    }

    static string TraducirLinea(string linea, SortedList<string, string> traductor)
    {
        string lineaTraducida = linea;

        foreach (KeyValuePair<string, string> entrada in traductor)
        {
            lineaTraducida = lineaTraducida.Replace(entrada.Key, entrada.Value);
        }

        return lineaTraducida;
    }
}
