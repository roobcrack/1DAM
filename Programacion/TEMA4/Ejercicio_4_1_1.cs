//Ruben Martinez Martinez

using System;

class Ejercicio_4_1_1{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<2; i++){
					Console.WriteLine("{0}-Exercise 4.1.1.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_1_1_1();
					break;
				case "2": Ejercicio_4_1_1_2();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
		Console.WriteLine("Program ended");
	}
	
	
/*Un programa que pida al usuario 4 números, los memorice (utilizando un
array), calcule su media aritmética y después muestre en pantalla la media y los
datos tecleados.*/

	static void Ejercicio_4_1_1_1(){
		int[] numbers = new int[4];
		
		for(int i=0; i<4; i++){
			Console.Write("Insert first number: ");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("The average of those numbers is: {0}", 
				(numbers[0] + numbers[1] + numbers[2] + numbers[3]) / 4);
	}
	
	
/*Un programa que pida al usuario 5 números reales (pista: necesitarás un
array de "float") y luego los muestre en el orden contrario al que se 
introdujeron.*/

	static void Ejercicio_4_1_1_2(){
		double[] numbers = new double[5];
		
		for(int i=0; i<5; i++){
			Console.Write("Insert real number: ");
			numbers[i] = Convert.ToDouble(Console.ReadLine());
		}
		
		for(int i=4; i>=0; i--){
			Console.Write("{0} ", numbers[i]);
		}
	}
}
