/*Crea un programa que escriba 6 líneas de texto, cada una de las cuales
estará formada por los números del 1 al 7. Debes usar dos variables llamadas
"linea" y "numero", y ambas deben estar declaradas en el "for".*/

using System;

class Ejercicio_2_2_8_1
{
	static void Main()
	{
		for(int line=0; line<6; line++)
		{
			for(int number=1; number<=10; number++)
			{
				Console.Write(number);
			}
			Console.WriteLine();
		}
	}
}
