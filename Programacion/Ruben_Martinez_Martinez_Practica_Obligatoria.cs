//Ruben Martinez Martinez

using System;

class StudentsStorage{
	struct MarksData{
		/*public byte evaluation1;
		public byte evaluation2;
		public byte evaluation3;
		public byte finalMark;*/
	}
	struct StudentsData{
		public string dni;
		public string name;
		public string surname;
		/*public string city;
		public string birthDate;
		public MarksData marks;*/1
	}
	
	static void Main(){
		StudentsData[] students = new StudentsData[100];
		int studentsCounter = 0;
		byte menuOption=0;
		
		do{	
			bool done=false;
			
			while(!done){
				try{
					Console.WriteLine("----------[MENU]----------");
					Console.WriteLine("[1].Add a student");
					Console.WriteLine("[0].Leave the program");
					Console.Write("Insert: ");
					menuOption = Convert.ToByte(Console.ReadLine());
					
					if(menuOption>=0 && menuOption<=1){ done = true; }
					else{ throw new Exception("Number not valid"); }
				} catch(Exception){ Console.WriteLine("  *NOT VALID INPUT*\n" + 
					"*NUMBER MUST BE 0->1*\n"); }
			}
			
			Console.WriteLine();
			switch(menuOption){
				case 0: Console.WriteLine("Leaving the program . . . "); break;
				case 1: AddStudent(students, studentsCounter); break;
			}
		}while(menuOption!=0);
	}
	
	static void AddStudent(StudentsData[] students, int studentsCounter){
		bool done=false;
		
		Console.WriteLine("{---[ADDING STUDENT]---}");
		/*while(!done){
			Console.WriteLine("//DNI example: 12345678A//");
			Console.Write("Insert DNI: ");
			string dni = Console.ReadLine();
			
			try{
				string number = dni.Substring(0, dni.Length);
				int numberInt = Convert.ToInt32(number);
				if(numberInt < 10000000 || numberInt > 99999999 || 
					!(dni[8]>='A' && dni[8]<='Z')){
					Console.WriteLine(" *DNI NOT VALID* \n");
				} else{
					students[studentsCounter].dni = dni;
					done = true;
				}
			} catch(Exception) { Console.WriteLine(" *DNI NOT VALID* \n"); }
		}*/
		
		done=false;
		while(!done){
			Console.WriteLine("//Name example: Guillermo Ruiz Puentes " +
			"(without second names//");
			Console.Write("Insert name: ");
			string name = Console.ReadLine();
			
			string[] fullName = name.Split();
			if(fullName.Length != 3){
				Console.WriteLine(" *NAME NOT VALID* \n");
			} else{
				students[studentsCounter].name = fullName[0];
				students[studentsCounter].surname = fullName[1]+" "+fullName[2];
				done = true;
			}
			
			done=false;
			while(!done){
				Console.WriteLine("//City example: Alicante//");
				Console.Write("Insert city: ");
				
			}
		}
	}
	
	static int CheckIfNumber(string number, int maxNumber, int minNumber){
		int numberInt = Convert.ToInt32(number);
		
		if(numberint > maxNumber || numberint < minNumber)
			return false;
		else
			return true;
	}
}
