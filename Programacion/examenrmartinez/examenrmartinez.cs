//Rubén Martínez Martínez

using System;
using System.Text;

class examenrmartínez{
	static void Main(){
		int option=1;
		
		do{
			Console.WriteLine("MENU");
			Console.WriteLine("1.InitialCaps");
			Console.WriteLine("2.GatherAndSortArrays");
			Console.WriteLine("6.ChristmasTree");
			try{
				option = Convert.ToInt32(Console.ReadLine());
			} catch(Exception e){ Console.WriteLine(e.Message); }
			
			switch(option){
				case 1: 
					Console.Write("Insert text: ");
					string text = Console.ReadLine();
					InitialCaps(text); 
					break;
				case 2: 
					int size = 0;
					Random rd = new Random();
					bool done = false;
					
					while(!done){
						Console.Write("Insert the size of the arrays: ");
						try{
							size = Convert.ToInt32(Console.ReadLine());
							if(size>0){ done = true; }
							else{ throw new Exception("Numbert must be > 0."); }
						} catch(Exception e){ Console.WriteLine(e.Message); }
					}
					int[] array1 = new int[size];
					int[] array2 = new int[size];
					int[] finalArray = new int[size*2];
					for(int i=0; i<size; i++){
						array1[i] = rd.Next(1, 10);
						array2[i] = rd.Next(1, 10);
					}
					GatherAndSortArrays(array1, array2, finalArray, size);
					break;
				case 6: 
					int height=0;
					char character='*';
					done=false;
					
					while(!done){
						try{
							Console.Write("Insert the height of the tree: ");
							height = Convert.ToInt32(Console.ReadLine());
							Console.Write("Insert the character(0 for default): ");
							character = Convert.ToChar(Console.ReadLine());
							if(height>0){ done = true; }
							else{ throw new Exception("Number must be > 0"); }
						} catch(Exception e){ Console.WriteLine(e.Message); }
					}
					ChristmasTree(height, character);
					break;
			}
		} while(option != 0);
	}
	
	static void InitialCaps(string text){
	/*	string newText="";
		string[] arr = text.Split(' ');
		for(int i=0; i<arr.Length; i++){
			newText = newText + " " + arr[i];
		}
		foreach(char letter in newText){
			char saveLastChar=' ';
			
			if(saveLastChar==' '){
				Console.Write(letter.ToUpper());
			} else{
				Console.Write(letter);
			}
		}*/
	}

	static void GatherAndSortArrays(int[] array1, int[] array2, int[] finalArray, int size){
		for(int i=0; i<size*2; i++){
			if(i<size){
				finalArray[i] = array1[i];
			} else{
				finalArray[i] = array2[i];
			}
			GatherAndSortArraysAux(finalArray);
		}
	}

	static void GatherAndSortArraysAux(int[] array){
		int temp;
		for(int i=0; i<array.Length-1; i++){
			for(int j=i+1; j<array.Length; j++){
					temp = array[i];
					array[i] = array[j];
					array[j] = temp;
			}
		}
	}
	
	static void ChristmasTree(int height, char character){
		character = character == '0' ? '*' : character;
		for(int i=0; i<height-2; i++){
			for(int j=0; j<height*2; j++){
				if((height%2==0 && ((j<=(height)+i || j<=(height)+i+1)) && 
					(j>=(height)-i)) || ((j<=(height)+i) && (j>=(height)-i))){
					Console.Write(character);
				} else{ Console.Write(" "); }
			}
			Console.WriteLine();
		}
		for(int i=0; i<2; i++){
			for(int j=0; j<height*2; j++){
				if((height%2==0 && ((j==height) || (j==height+1))) || 
					(j==height)){
					Console.Write(character);
				} else{ Console.Write(" "); }
			}
			Console.WriteLine();
		}
	}
}
