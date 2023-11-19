using System;

class Am{
	
	struct personData{
		public string name;
		public string address;
		public int phoneNumber;
		public byte age;
	}
	static void Main(){
		personData[] person = new personData[50];
		
		int i=0;
		do{
			Console.Write("Insert name: ");
			person[i].name = Console.ReadLine();
			Console.Write("Insert address: ");
			person[i].address = Console.ReadLine();
			Console.Write("Insert phone number: ");
			person[i].phoneNumber = Convert.ToInt32(Console.ReadLine());
			Console.Write("Insert age: ");
			person[i].age = Convert.ToByte(Console.ReadLine());
			i++;
		} while(person[i].name != "");
		
		int insert = 1;
		do{
			Console.WriteLine("1-Choose option");
			Console.WriteLine("2-Show list of all names");
			Console.WriteLine("3-Show people from x age");
			Console.WriteLine("4-Show people with x initial");
			Console.WriteLine("0-Exit");
			insert = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			
			switch(insert){
				case 1: 
					for(int j=0; j<person.Length; j++){
						Console.WriteLine("{0} ", person[j].name);
					}
					break;
			}
			
		} while(insert != 0);
	}
}
