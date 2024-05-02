//Rubén Martínez Martínez
/*Un programa que pida el nombre, el apellido y la edad de una persona, los
almacene en un "struct" y luego muestre los tres datos en una misma línea,
separados por comas.*/

using System;

struct personData{
	public string name;
	public string surname;
	public byte age;
}

class Ejercicio_4_6_1{
	static void Main(){
		personData person;
		
		Console.Write("Insert name: ");
		person.name = Console.ReadLine();
		Console.Write("Insert surname: ");
		person.surname = Console.ReadLine();
		Console.Write("Insert age: ");
		person.age = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("\n{0} {1}, {2} years old", 
			person.name, person.surname, person.age);
	}
}
