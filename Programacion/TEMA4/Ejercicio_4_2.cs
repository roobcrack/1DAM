//Ruben Martinez Martienz

using System;

class Ejercicio_4_2{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<5; i++){
					Console.WriteLine("{0}-Exercise 4.1.1.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_2_1();
					break;
				case "2": Ejercicio_4_2_2();
					break;
				case "3": Ejercicio_4_2_3();
					break;
				case "4": Ejercicio_4_2_4();
					break;
				case "5": Ejercicio_4_2_5();
					break;
				case "6": Ejercicio_4_2_6();
					break;
				case "7": Ejercicio_4_2_7();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
/*Un programa que pida al usuario dos bloques de 10 números enteros
(usando un array de dos dimensiones). Después deberá mostrar el mayor dato
que se ha introducido en cada uno de ellos.*/
	static void Ejercicio_4_2_1(){
		int[,] numbers = new int[2,10];
		int[] maxNumber = new int[2];
		
		for(int i=0; i<2; i++){
			Console.WriteLine("For the array {0}.", i+1);
			maxNumber[i] = 0;
			for(int j=0; j<10; j++){
				Console.Write("Insert number: ");
				numbers[i,j] = Convert.ToInt32(Console.ReadLine());
				if(numbers[i,j] > maxNumber[i]){
					maxNumber[i] = numbers[i,j];
				}
			}
		}
		Console.WriteLine("Max number in 1: {0}. Max number in 2: {1}", 
			maxNumber[0], maxNumber[1]);
	}
	
/*Un programa que pida al usuario dos bloques de 6 cadenas de texto.
Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno
de los dos bloques de información anteriores.*/
	static void Ejercicio_4_2_2(){
		string[][] blocks;
		blocks = new string[2][];
		blocks[0] = new string[6];
		blocks[1] = new string[6];
		string insert;
		
		for(int i=0; i<2; i++){
			Console.WriteLine("Insert for block {0}", i+1);
			for(int j=0; j<6; j++){
				Console.Write("{0}: ", j+1);
				blocks[i][j] = Console.ReadLine();
			}
		}
		Console.Write("Insert a string to search: ");
		insert = Console.ReadLine();
		
		for(int i=0; i<2; i++){
			for(int j=0; j<6; j++){
				if(blocks[i][j] == insert){
					Console.WriteLine("String was founded in {0},{1} part", 
						i+1, j+1);
				}
			}
		}
		Console.WriteLine("Program done");
	}
	
/*Un programa que pregunte al usuario el tamaño que tendrán dos bloques
de números enteros (por ejemplo, uno de 10 elementos y otro de 12). Luego
pedirá los datos para ambos bloques de datos. Finalmente deberá mostrar el
mayor dato que se ha introducido en cada uno de ellos*/
	static void Ejercicio_4_2_3(){
		int capacity1, capacity2;
		
		Console.Write("Insert capacity 1: ");
		capacity1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Insert capacity 2: ");
		capacity2 = Convert.ToInt32(Console.ReadLine());
		
		int[][] blocks;
		blocks = new int[2][];
		blocks[0] = new int[capacity1];
		blocks[1] = new int[capacity2];

		
		for(int i=0; i<2; i++){
			int capacity;
			
			capacity = i>0 ? capacity = capacity2 : capacity = capacity1;
			Console.WriteLine("Block {0}", i+1);
			for(int j=0; j<capacity; j++){
				Console.Write("Insert {0}: ", j+1);
				blocks[i][j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		int maxNumber1 = blocks[0][0], maxNumber2 = blocks[1][0];
			
		for(int i=0; i<capacity1; i++){
			if(blocks[0][i] > maxNumber1){
				maxNumber1 = blocks[0][i];
			}
		}
		for(int i=0; i<capacity2; i++){
			if(blocks[1][i] > maxNumber2){
				maxNumber2 = blocks[1][i];
			}
		}
		Console.WriteLine("The first max number is: {0}, and the second: {1}.",
			maxNumber1, maxNumber2);
	}
	
	static void Ejercicio_4_2_4(){
		
	}
	
	static void Ejercicio_4_2_5(){
		
	}
	
	static void Ejercicio_4_2_6(){
		
	}
	
	static void Ejercicio_4_2_7(){
		
	}
}
