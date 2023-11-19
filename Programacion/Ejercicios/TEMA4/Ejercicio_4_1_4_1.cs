//Ruben Martinez Martinez

using System;

class Ejercicio_4_1_4{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<4; i++){
					Console.WriteLine("{0}-Exercise 4.1.1.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_1_4_1();
					break;
				case "2": Ejercicio_4_1_4_2();
					break;
				case "3": Ejercicio_4_1_4_3();
					break;
				case "4": Ejercicio_4_1_4_4();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Crea una variante del ejemplo anterior (04_01_04a) que pida al usuario el
dato a buscar, avise si ese dato no aparece, y que diga cuántas veces se ha
encontrado en caso contrario.*/
	static void Ejercicio_4_1_4_1(){
		int[] numbers = {2, 3, 2, 3, 4, 5, 6, 3, 2};
		
		Console.Write("Insert number to search: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		int counter=0;
		for(int i=0; i<numbers.Length; i++){
			if(number == numbers[i]){ counter++; }
		}
		if(counter != 0){ 
			Console.WriteLine("Number was found {0} times", counter);
		}else{ 
			Console.WriteLine("Number wasn't founded"); 
		}
	}
	
/*Crea una variante del ejemplo anterior (04_01_04a) que añada un dato
introducido por el usuario al final de los datos existentes.*/
	static void Ejercicio_4_1_4_2(){
		int[] numbers = {2, 3, 2, 3, 4, 5, 6, 3, 2, 0};
		int amount = 9;
		
		Console.Write("Insert new number: ");
		numbers[amount] = Convert.ToInt32(Console.ReadLine());
		amount++;
		
		for(int i=0; i<amount; i++){
			Console.Write("{0} ", numbers[i]);
		}	
		Console.WriteLine();
	}
	
/*Crea una variante del ejemplo anterior (04_01_04a) que inserte un dato
introducido por el usuario en la posición que elija el usuario. Debe avisar si 
la posición escogida es incorrecta (porque esté más allá del final de los datos)
*/
	static void Ejercicio_4_1_4_3(){
		int[] numbers = {3, 2, 4, 3, 0};
		int insert, number;
		
		do{
			Console.Write("Choose position between 1-5: ");
			insert = Convert.ToInt32(Console.ReadLine());
		}while(insert>5||insert<1);
			Console.Write("Choose the number: ");
			number = Convert.ToInt32(Console.ReadLine());
		
		for(int i=4; i>insert-1; i--){
			numbers[i] = numbers[i-1];
		}
		numbers[insert] = number;
		
		for(int i=0; i<5; i++){
			Console.Write("{0} ", numbers[i]);
		}
	}
/*Crea una variante del ejemplo anterior (04_01_04a) que borre el dato que
se encuentre en la posición que elija el usuario. Debe avisar si la posición 
escogida no es válida.*/
	static void Ejercicio_4_1_4_4(){
		int[] numbers = {3, 2, 4, 3, 0};
		int removeN;
		
		do{
			Console.Write("Choose position between 1-5: ");
			removeN = Convert.ToInt32(Console.ReadLine());
		}while(removeN>5||removeN<1);
		
		for(int i=removeN-1; i>4-1; i++){
			numbers[i] = numbers[i+1];
		}
		
		for(int i=0; i<4; i++){
			Console.Write("{0} ", numbers[i]);
		}
	}
}
