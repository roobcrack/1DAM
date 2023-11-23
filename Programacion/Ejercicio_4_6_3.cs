//Ruben Martinez Martinez
/*Un programa que sea capaz de almacenar los datos de 50 personas:
nombre, dirección, teléfono, edad (usando una tabla de structs). Deberá ir
pidiendo los datos uno por uno, hasta que un nombre se introduzca vacío (se
pulse Intro sin teclear nada). Entonces deberá aparecer un menú que permita:
+ Mostrar la lista de todos los nombres.
+ Mostrar las personas de una cierta edad.
+ Mostrar las personas cuya inicial sea la que el usuario indique.
+ Salir del programa
(lógicamente, este menú debe repetirse hasta que se escoja la opción de "salir")
*/

using System;

struct personData{
	public string name;
	public string adress;
	public int phone;
	public byte age;
}

class Ejercicio_4_6_3{
	static void Main(){
		personData[] person = new personData[50];
		int counter=0;
		
		do{
			Console.WriteLine("Person {0}", counter+1);
			Console.Write("Insert name: ");
			person[counter].name = Console.ReadLine();
			if(person[counter].name==""){ break; }
			Console.Write("Insert adress: ");
			person[counter].adress = Console.ReadLine();
			Console.Write("Insert phone number: ");
			person[counter].phone = Convert.ToInt32(Console.ReadLine());
			Console.Write("Insert age: ");
			person[counter].age = Convert.ToByte(Console.ReadLine());
			Console.WriteLine();
			counter++;
		} while(true);
		
		byte insert;
		do{
			Console.WriteLine("1. Show all names.");
			Console.WriteLine("2. Show people with x age.");
			Console.WriteLine("3. Show people with x initial.");
			Console.WriteLine("0. Exit.");
			Console.Write("Insert: ");
			insert = Convert.ToByte(Console.ReadLine());
			
			Console.WriteLine();
			switch(insert){
				case 0: Console.WriteLine("Leaving the program..."); break;
				case 1: 
					for(int i=0; i<counter; i++){
						Console.WriteLine("{0}. {1}", i+1, person[i].name);
					}
					break;
				case 2: 
					Console.Write("Insert age: ");
					byte age = Convert.ToByte(Console.ReadLine());
					
					for(int i=0; i<counter; i++){
						if(person[i].age == age){
							Console.WriteLine("{0}. {1}", i+1, person[i].name);
						}
					}
					break;
				case 3: 
					Console.Write("Insert initial: ");
					char initial = Convert.ToChar(Console.ReadLine());
					for(int i=0; i<counter; i++){
						if(person[i].name[0]==initial){
							Console.WriteLine("{0}. {1}", i+1, person[i].name);
						}
					}
					break;
				default: Console.WriteLine("Wrong insert"); break;
				}
			Console.WriteLine();
		}while(insert!=0);
	}
}
