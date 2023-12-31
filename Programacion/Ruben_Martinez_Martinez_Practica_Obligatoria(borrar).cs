//Ruben Martinez Martinez

using System;

class StudentsStorage{
	struct MarksData{
		public int ev1;
		public int ev2;
		public int ev3;
		public float final;
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
		public BirthDateData birth;
		public MarksData marks;
	}
	
	static void Main(){
		StudentsData[] students = new StudentsData[100];
		int studentsCounter = 0;
		byte menuOption=0;
		borrar(students, ref studentsCounter);
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
					Console.Write(" Insert: ");
					menuOption = Convert.ToByte(Console.ReadLine());
					
					if(menuOption>=0 && menuOption<=5){ done = true; }
					else{ throw new Exception("Number not valid"); }
				} catch(Exception){ Console.WriteLine("  *NOT VALID INPUT*\n" + 
					"*NUMBER MUST BE 0->5*\n"); }
			}
			
			Console.WriteLine();
			switch(menuOption){
				case 0: Console.WriteLine("Leaving the program . . . "); break;
				case 1: AddStudent(students, ref studentsCounter); break;
				case 2: DeleteStudent(students, ref studentsCounter); break;
<<<<<<< HEAD:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria(borrar).cs
				case 3: SortStudents(students, studentsCounter, SelectOption(3)); break;
				case 4: SearchStudent(students, studentsCounter, SelectOption(2)); break;
				case 5: ShowStudents(students, studentsCounter, 0); break;
=======
				case 3: 
					bool done2 = false;
					while(!done2){
						try{
							Console.WriteLine("-Select what field you want to" +
							" search");
							Console.Write("[1]-DNI \n[2]-Surname\n[0]-Exit \n" +
							"Insert: ");
							int typeSearch = 
								Convert.ToInt32(Console.ReadLine());
							if(typeSearch >= 0 && typeSearch <=2){
								if(typeSearch != 0){
									SortStudents(students, studentsCounter, 
										typeSearch);
								}
								done2 = true;
							} else { throw new Exception(" *NOT VALID INSERT*" +
								" "); }
						} catch(Exception) { Console.WriteLine(" *NOT VALID " +
							"INSERT* "); }
					}
					break;
				case 5: ShowStudents(students, studentsCounter); break;
>>>>>>> b7c76b0c5c64a224063d71d8c0a2af906908d32b:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria.cs
			}
		}while(menuOption!=0);
	}
	
	static int SelectOption(int options){
		bool done = false;
		string[] optionsString = {"DNI", "Surname", "City"};
		while(!done){
			try{
				Console.WriteLine("Select what field you want to search");
				for(int i=0; i<options; i++){
					Console.WriteLine("[{0}].{1}", i+1, optionsString[i]);
				}
				Console.Write("[0].Exit \n Insert:");
				int typeSearch = Convert.ToInt32(Console.ReadLine());
				if(typeSearch >= 0 && typeSearch <=options){
					if(typeSearch != 0){
						return typeSearch;
					}
					done = true;
				} else { throw new Exception(" *NOT VALID INSERT* \n"); }
			} catch(Exception) { Console.WriteLine(" *NOT VALID INSERT* \n"); }
		}
		return 0;
	}
	//-------------------------------------------------------------------------
	static void AddStudent(StudentsData[] s, ref int count){
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
			"(without second names)//");
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
		done = false;
		while(!done){
			try {
				Console.WriteLine("//Birth date example: 10-8-2003//");
				Console.Write(" Insert date: ");
				string birthDate = Console.ReadLine();
				
				string[] dateSplitted = birthDate.Split('-');
			
				if(dateSplitted.Length == 3){
					s[count].birth.day = 
						ConvertCheckNumber(dateSplitted[0], 1, 31);
					s[count].birth.month = 
						ConvertCheckNumber(dateSplitted[1], 1, 12);
					s[count].birth.year = 
						ConvertCheckNumber(dateSplitted[2], 1900, 2023);
					if(s[count].birth.day < 0 || s[count].birth.month < 0 ||
						s[count].birth.year < 0){
						throw new Exception(" *DATE NOT VALID* \n");
					} else{
						done = true;
					}
				} else{ Console.WriteLine(" *DATE NOT VALID* \n"); }
			} catch(Exception){ Console.WriteLine(" *DATE NOT VALID* \n"); }
		}
		//Marks------
		done = false;
		while(!done){
			try {
				Console.WriteLine("//Marks example: 8 7 8 (3 evaluations)//");
				Console.Write(" Insert marks: ");
				string marks = Console.ReadLine();
				
				string[] marksSplitted = marks.Split();
			
				if(marksSplitted.Length == 3){
					s[count].marks.ev1 = 
						ConvertCheckNumber(marksSplitted[0], 0, 10);
					s[count].marks.ev2 = 
						ConvertCheckNumber(marksSplitted[1], 0, 10);
					s[count].marks.ev3 = 
						ConvertCheckNumber(marksSplitted[2], 0, 10);
					if(s[count].marks.ev1 < 0 || s[count].marks.ev2 < 0 || 
						s[count].marks.ev3 < 0){
						throw new Exception(" *MARKS NOT VALID* \n");
					} else{
						s[count].marks.final = (s[count].marks.ev1 + 
							s[count].marks.ev2 + s[count].marks.ev3) / 3;
						done = true;
					}
				} else{ Console.WriteLine(" *MARKS NOT VALID* \n"); }
			} catch(Exception){ Console.WriteLine(" *MARKS NOT VALID* \n"); }
		}
		count++;
	}
	
	static int ConvertCheckNumber(string number, int minNumber, int maxNumber){
		
		int numberInt = Convert.ToInt32(number);
		
		if(numberInt <= maxNumber && numberInt >= minNumber){
			return numberInt;
		} else{
			return -1;
		}
	}
	//-------------------------------------------------------------------------
	static void DeleteStudent(StudentsData[] s, ref int count){
		bool done = false;
		while(!done){
			try{
				ShowStudents(s, count, 0);
				Console.WriteLine("Insert the number you want to delete (0 to exit)");
				Console.Write(" Insert: ");
				int insert = Convert.ToInt32(Console.ReadLine());
				if(insert > count || insert < 0){
					throw new Exception(" *INSERT NOT VALID* \n");
				} else{
					if(insert != 0){
						if(DeleteAuxStudent(s, count, insert)){
							count--;
						} else {
							throw new Exception(" *COULD NOT BE DELETED*\n");
						}
					}
					done = true;
				}
			} catch(Exception) { Console.WriteLine(" *INSERT NOT VALID* \n"); }
		}
	}
	
	static bool DeleteAuxStudent(StudentsData[] s, int count, int insert){
		try{
			for(int i=insert-1; i<count; i++){
				s[i] = s[i+1];
			}
			return true;
		} catch(Exception) { return false; }
		
	}
	//-------------------------------------------------------------------------
<<<<<<< HEAD:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria(borrar).cs
	static void ShowStudents(StudentsData[] s, int count, int current){
		for(int i=current; i<count; i++){
			Console.Write("{0}. Name: {1} {2} | DNI: {3} | City:{4} | Birthdate: {5}-{6}-{7} | " +
				"Marks-> 1st: {8} - 2nd:{9} - 3rd{10} - Final:{11}", i+1, s[i].name, 
				s[i].surname, s[i].dni, s[i].city, s[i].birthDate.day, 
				s[i].birthDate.month, s[i].birthDate.year, s[i].marks.ev1, 
=======
	static void ShowStudents(StudentsData[] s, int count){
		for(int i=0; i<count; i++){
			Console.Write("{0}. Name: {1} {2} | DNI: {3} | City:{4} | "+
				"Birthdate: {5}-{6}-{7} | Marks-> 1st: {8} - 2nd:{9} - " +
				"3rd{10} - Final:{11}", i+1, s[i].name, 
				s[i].surname, s[i].dni, s[i].city, s[i].birth.day, 
				s[i].birth.month, s[i].birth.year, s[i].marks.ev1, 
>>>>>>> b7c76b0c5c64a224063d71d8c0a2af906908d32b:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria.cs
				s[i].marks.ev2,	s[i].marks.ev3, s[i].marks.final);
			Console.WriteLine();
		}
	}
	//-------------------------------------------------------------------------
	static void SearchStudent(StudentsData[] s, int count, int type){
		SortStudents(s, count, type);
		Console.WriteLine("Type the text you want to search");
		Console.Write(" Insert: ");
		string textSearch = Console.ReadLine();
		
		for(int i=0; i<count; i++){
			switch(type){
				case 1: if(RecursiveSearch(s[i].dni, count, textSearch)){
							ShowStudents(s, i, i-1);
						} else{
							Console.WriteLine(" *STUDENT NOT FOUNDED* "); 
						} break;
				case 2: if(RecursiveSearch(s[i].surname, count, textSearch)){
							ShowStudents(s, i, i-1);
						} else{
							Console.WriteLine(" *STUDENT NOT FOUNDED* "); 
						} break;
			}
		}
	}
	
	static bool RecursiveSearch(string currentText, int count, string textSearch){
		if(currentText==textSearch){
			return true;
		} else{
			return false;
		}
	}
	//-------------------------------------------------------------------------
	static void SortStudents(StudentsData[] s, int count, int type){
		
		for(int i=0; i<count-1; i++){
			for(int j=0; j<count-1; j++){
				switch(type){
					case 1: if(string.Compare(s[j].dni, s[j+1].dni, false)>0){ 
								SortAuxStudents(s, count, i, j);
							} break;
					case 2: if(string.Compare(s[j].surname, s[j+1].surname, false)>0){
								SortAuxStudents(s, count, i, j);
							} break;
					case 3: if(string.Compare(s[j].city, s[j+1].city, false)>0){
								SortAuxStudents(s, count, i, j);
							} break;
				}
			}
		}
	}
	
	static void SortAuxStudents(StudentsData[] s, int count, int i, int j){
		StudentsData tempStudent = s[j];
		s[j] = s[j+1];
		s[j+1] = tempStudent;
	}
	
	static void borrar(StudentsData[] s, ref int count){
		count = 5;
		//1st
		s[0].dni = "50382239A";
		s[0].name = "Ruben";
		s[0].surname = "Martinez Martinez";
		s[0].city = "Mutxamel";
		s[0].birth.day = 10;
		s[0].birth.month = 8;
		s[0].birth.year = 2003;
		s[0].marks.ev1 = 8;
		s[0].marks.ev2 = 9;
		s[0].marks.ev3 = 10;
		s[0].marks.final = 9;
		//2nd
		s[1].dni = "50387383H";
		s[1].name = "Amanda";
		s[1].surname = "Correas Malfeito";
		s[1].city = "Alicante";
<<<<<<< HEAD:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria(borrar).cs
		s[1].birthDate.day = 23;
		s[1].birthDate.month = 11;
		s[1].birthDate.year = 2003;
		s[1].marks.ev1 = 10;
		s[1].marks.ev2 = 10;
		s[1].marks.ev3 = 10;
		s[1].marks.final = 10;
=======
		s[1].birth.day = 19;
		s[1].birth.month = 3;
		s[1].birth.year = 2013;
		s[1].marks.ev1 = 7;
		s[1].marks.ev2 = 8;
		s[1].marks.ev3 = 9;
		s[1].marks.final = 8;
>>>>>>> b7c76b0c5c64a224063d71d8c0a2af906908d32b:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria.cs
		//3rd
		s[2].dni = "56785523J";
		s[2].name = "Juan";
		s[2].surname = "Ageitos Bonaldi";
		s[2].city = "Benidorm";
<<<<<<< HEAD:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria(borrar).cs
		s[2].birthDate.day = 2;
		s[2].birthDate.month = 1;
		s[2].birthDate.year = 2000;
=======
		s[2].birth.day = 24;
		s[2].birth.month = 11;
		s[2].birth.year = 2000;
>>>>>>> b7c76b0c5c64a224063d71d8c0a2af906908d32b:Programacion/Ruben_Martinez_Martinez_Practica_Obligatoria.cs
		s[2].marks.ev1 = 10;
		s[2].marks.ev2 = 10;
		s[2].marks.ev3 = 10;
		s[2].marks.final = 10;
		//4th
		s[3].dni = "80420756K";
		s[3].name = "Jonathan";
		s[3].surname = "Vera Abascal";
		s[3].city = "Ecuador";
		s[3].birth.day = 15;
		s[3].birth.month = 12;
		s[3].birth.year = 1967;
		s[3].marks.ev1 = 8;
		s[3].marks.ev2 = 9;
		s[3].marks.ev3 = 10;
		s[3].marks.final = 9;
		//5th
		s[4].dni = "46783985Y";
		s[4].name = "José";
		s[4].surname = "Benjamín Zarrapastroso";
		s[4].city = "Chile";
		s[4].birth.day = 1;
		s[4].birth.month = 2;
		s[4].birth.year = 2003;
		s[4].marks.ev1 = 4;
		s[4].marks.ev2 = 5;
		s[4].marks.ev3 = 6;
		s[4].marks.final = 5;
	}
}
