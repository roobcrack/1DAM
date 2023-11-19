//Ruben Martinez Martinez

using System;

class Ejercicio{
	static void Main(){
		string[] names = new string[10];
		int insert=10, amount=0, maxSpace=10;
		
		do{
			Console.WriteLine("Choose what you want to do: ");
			for(int i=0; i<6; i++){
				string[] options = {"Add", "Insert", "Remove", "Show", "Search",
					"Show"};
				Console.WriteLine("{0}-{1} data", i+1, options[i]);
			}
			Console.WriteLine("0-Exit program");
			
			Console.Write("Insert: ");
			try{
				insert = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e){ Console.WriteLine("{0}", e.Message); }
			
			insert = Convert.ToInt32(Console.ReadLine());
			switch(insert){
				case 1: 
					names[amount] = Console.ReadLine();
					amount++;
					break;
				case 2: Insert(); break;
				case 3: Remove(); break;
				case 4: Show(); break;
				case 5: Show(); break;
				case 6: Search(); break;
				default: Console.WriteLine("Not valid insert\n"); break;
			}
		}while(insert!=0);
		Console.WriteLine("\nExit program...");
	}
	
	static void Add(){
		
	}
	
	static void Insert(){
		
	}
	
	static void Remove(){
		
	}
	
	static void Show(){
		
	}
	
	static void Search(){
		
	}
	
	static void Sort(){
		
	}
}
