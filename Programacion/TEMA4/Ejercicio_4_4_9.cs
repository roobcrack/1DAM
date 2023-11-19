//Ruben Martinez Martinez

using System;
using System.Text;

class Ejercicio_4_4_9{
	static void Main(){
		string number;

		while(true){
				Console.WriteLine("Choose exercise (0 to exit)");
				for(int i=0; i<3; i++){
					Console.WriteLine("{0}-Exercise 4.4.9.{0}", i+1);
				}
			number = Console.ReadLine();
			
			if(number == "0"){ break; }
			Console.WriteLine();
			
			switch(number){
				case "1": Ejercicio_4_4_9_1();
					break;
				case "2": Ejercicio_4_4_9_2();
					break;
				case "3": Ejercicio_4_4_9_3();
					break;
				default: Console.WriteLine("Not aviable");
					break;
			}
			Console.WriteLine();
		}
	}
	
/*Un programa que pida una cadena al usuario y la modifique, de modo
que todas las vocales se conviertan en "o".*/
	static void Ejercicio_4_4_9_1(){
		
		Console.Write("Insert a phrase: ");
		StringBuilder word = new StringBuilder(Console.ReadLine());
		
		for(int i=0; i<word.Length; i++){
			if(word[i]=='a' || word[i]=='e' || word[i]=='i' || 
				word[i]=='o' || word[i]=='u'){
				word[i] = 'o';
			}
		}
		Console.WriteLine(word);
	}
	
/*Un programa que pida una cadena al usuario y la modifique, de modo
que las letras de las posiciones impares (primera, tercera, etc.) estén en
minúsculas y las de las posiciones pares estén en mayúsculas, mostrando el
resultado en pantalla. Por ejemplo, a partir de un nombre como "Nacho", la
cadena resultante sería "nAcHo"*/
	static void Ejercicio_4_4_9_2(){
		
		Console.Write("Insert text: ");
		StringBuilder text = new StringBuilder(Console.ReadLine());
		
		for(int i=0; i<text.Length; i++){
			if(i % 2 == 0){
				/*text[i] = text[i].ToUpper();*/
			}
		}
	}
	
/*Crea un juego del ahorcado, en el que un primer usuario introduzca la
palabra a adivinar, se muestre ésta oculta con guiones (-----) y el programa 
acepte las letras que introduzca el segundo usuario, cambiando los guiones por 
letras correctas cada vez que acierte (por ejemplo, a---a-t-). La partida 
terminará cuando se acierte la palabra por completo o el usuario agote sus 8 
intentos.*/
	static void Ejercicio_4_4_9_3(){
		const string answere = "farruquito";
		StringBuilder word = new StringBuilder("----------");
		int tries=9;
		string check;
		
		do{
			tries--;
			Console.WriteLine("//{0}//", word);
			char insert = Convert.ToChar(Console.ReadLine());
			
			for(int i=0; i<answere.Length; i++){
				if(answere[i] == insert){
					word[i] = insert;
				}
			}
			check = word.ToString();
		} while(tries > 0 || answere != check);
		
		if(tries > 0){
			Console.WriteLine("Congrats");
		} else{
			Console.WriteLine("You have lost");
		}
	}
}
