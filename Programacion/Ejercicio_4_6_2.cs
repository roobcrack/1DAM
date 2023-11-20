//Ruben Martinez Martinez
/*Un programa que pida datos de 8 personas: nombre, día de nacimiento,
mes de nacimiento, y año de nacimiento (que se deben almacenar en un array de
structs). Después deberá repetir lo siguiente: preguntar un número de mes y
mostrar en pantalla los datos de las personas que cumplan los años durante ese
mes. Terminará de repetirse cuando se teclee 0 como número de mes.*/

using System;

struct birthDateData{
	public byte day;
	public byte month;
	public short year;
}
struct personData{
	public string name;
	public birthDateData birthDate;
}
class EJercicio_4_6_2{
	static void Main(){
		personData[] person = new personData[8];
		
		for(int i=0; i<8; i++){
			Console.WriteLine("Person {0}: ", i+1);
			Console.Write("Insert name: ");
			person[i].name = Console.ReadLine();
			Console.WriteLine("Now insert yout birth date.");
			Console.Write("Day: ");
			person[i].birthDate.day = Convert.ToByte(Console.ReadLine());
			Console.Write("Month: ");
			person[i].birthDate.month = Convert.ToByte(Console.ReadLine());
			Console.Write("Year: ");
			person[i].birthDate.year = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine();
		}
		
		byte monthInsert;
		do{
			Console.Write("Insert month to search: ");
			monthInsert = Convert.ToByte(Console.ReadLine());
			
			for(int i=0; i<8; i++){
				if(person[i].birthDate.month == monthInsert){
					Console.WriteLine("{0} will be {1} years old", 
						person[i].name, 2023-person[i].birthDate.year);
				}
			}
			Console.WriteLine();
		} while(monthInsert != 0);
	}
}
