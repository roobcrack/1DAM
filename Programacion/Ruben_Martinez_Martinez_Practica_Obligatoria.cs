//Ruben Martinez Martinez

using System;

class StudentsStorage{
	struct MarksData{
		public int ev1;
		public int ev2;
		public int ev3;
		public int final;
	}
	struct BirthDateData{
		public int day;
		public int month;
		public int year;
	}
	struct StudentsData{
		public string dni;
		public string name;
		public string surname;
		public string city;
		public BirthDateData birthDate;
		public MarksData marks;
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
					Console.WriteLine("[1].Add student");
					Console.WriteLine("[2].Delete student");
					Console.WriteLine("[3].Sort students");
					Console.WriteLine("[4].Search student");
					Console.WriteLine("[5].Show students");
					Console.WriteLine("[0].Leave the program");
					Console.Write("Insert: ");
					menuOption = Convert.ToByte(Console.ReadLine());
					
					if(menuOption>=0 && menuOption<=5){ done = true; }
					else{ throw new Exception("Number not valid"); }
				} catch(Exception){ Console.WriteLine("  *NOT VALID INPUT*\n" + 
					"*NUMBER MUST BE 0->5*\n"); }
			}
			
			Console.WriteLine();
			switch(menuOption){
				case 0: Console.WriteLine("Leaving the program . . . "); break;
				case 1: AddStudent(students, studentsCounter); break;
				case 5: 
					Console.WriteLine("-Select what field you want to search");
					Console.Write("[1]-DNI \n[2]-Surname \nInsert: ");
					int typeSearch = Convert.ToInt32(Console.ReadLine());
					break;
				case 4: ShowStudents(students, studentsCounter); break;
			}
		}while(menuOption!=0);
	}
	//-------------------------------------------------------------------------
	static void AddStudent(StudentsData[] s, int count){
		bool done=false;
		//DNI------
		Console.WriteLine("{---[ADDING STUDENT]---}");
		while(!done){
			Console.WriteLine("//DNI example: 12345678A//");
			Console.Write("Insert DNI: ");
			string dni = Console.ReadLine();
			
			try{
				string number = dni.Substring(0, (dni.Length-1));
				int numberInt = ConvertCheckNumber(number, 10000000, 99999999);
				if(dni[8]>='A' && dni[8]<='Z'){
					s[count].dni = dni;
					done = true;
				} else{
					Console.WriteLine(" *DNI NOT VALID* \n");
				}
			} catch(Exception) { Console.WriteLine(" *DNI NOT VALID* \n"); }
		}
		//Name-------
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
				s[count].name = fullName[0];
				s[count].surname = fullName[1]+" "+fullName[2];
				done = true;
			}
		}
		//City------
		Console.WriteLine("//City example: Alicante//");
		Console.Write("Insert city: ");
		s[count].city = Console.ReadLine();
		//BirthDate------
		do{
			try {
				Console.WriteLine("//Birth date example: 10-8-2003//");
				Console.Write(" Insert date: ");
				string birthDate = Console.ReadLine();
				
				string[] dateSplitted = birthDate.Split('-');
			
				if(dateSplitted.Length == 3){
					s[count].birthDate.day = ConvertCheckNumber(dateSplitted[0], 1, 31);
					s[count].birthDate.month = ConvertCheckNumber(dateSplitted[1], 1, 12);
					s[count].birthDate.year = ConvertCheckNumber(dateSplitted[2], 1900, 2023);
				} else{ Console.WriteLine(" *DATE NOT VALID* \n"); }
			} catch(Exception){ Console.WriteLine(" *DATE NOT VALID* \n"); }
			Console.WriteLine("{0}-{1}-{2}", s[count].birthDate.day, s[count].birthDate.month, s[count].birthDate.year);
		}while(s[count].birthDate.day == 0 || s[count].birthDate.month == 0 || s[count].birthDate.year == 0);
		//Marks------
		done=false;
		while(!done){
			
		}
	}
	//-------------------------------------------------------------------------
	static int ConvertCheckNumber(string number, int minNumber, int maxNumber){
		
		int numberInt = Convert.ToInt32(number);
		
		if(numberInt < maxNumber && numberInt > minNumber){
			return numberInt;
		} else{
			return 0;
		}
	}
	//-------------------------------------------------------------------------
	static void AskForMark(StudentsData[] s, int count){
		
	}
	//-------------------------------------------------------------------------
	static void ShowStudents(StudentsData[] s, int count){
		for(int i=0; i<count; i++){
			Console.Write("{0}. Name:{1} {2}, City:{3}, Birthdate:{4}-{5}-{6}, " +
				"Marks: 1st:{7}, 2nd:{8}, 3rd{9}, Final:{10}", s[i].name, 
				s[i].surname, s[count].city, s[i].birthDate.day, 
				s[i].birthDate.month, s[i].birthDate.year, s[i].marks.ev1, 
				s[i].marks.ev2,	s[i].marks.ev3, s[i].marks.final);
			Console.WriteLine();
		}
	}
	//-------------------------------------------------------------------------
	static void SearchStudent(StudentsData[] s, int count, int type){
		
	}
}
