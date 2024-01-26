import java.util.Scanner;

public class Menu{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.println("Choose the exercise between 1-3");
		int exercise = sc.nextInt();

		switch(exercise){
			case 1: 
				int language;

				System.out.println("1-Spanish | 2-English | 3-Valencian | 4-Italian | 5-German");
				System.out.print("Select the language: ");
				language = sc.nextInt();

				switch(language){
					case 1: System.out.println("Hola, ¿cómo estás?"); break;
					case 2: System.out.println("Hello, how are you?"); break;
					case 3: System.out.println("Hola, com va?"); break;
					case 4: System.out.println("Ciao, come stai?"); break;
					case 5: System.out.println("Hallo, wie geht es dir?"); break;
					default: System.out.println("Not founded");
				}
					break;
			case 2: 
				int number1, number2, number3;

				System.out.print("Type first number: ");
				number1 = sc.nextInt();
				System.out.print("Type second number: ");
				number2 = sc.nextInt();
				System.out.print("Type third number: ");
				number3 = sc.nextInt();

				if(number1 % number2 == 0 && number1 % number3 != 0){
					System.out.println("It is divided by the second number");
				} else if(number1 % number2 != 0 && number1 % number3 == 0){
					System.out.println("It is divided by third number");
				} else if(number1 % number2 == 0 && number1 % number3 == 0){
					System.out.println("It is divided by both");
				} else{
					System.out.println("It is divided by none");
				}
					break;
			case 3: 
				int month;

				System.out.print("Type the number of a month(1-12): ");
				month = sc.nextInt();

				switch(month){
					case 1: System.out.println("It has 31 days"); break;
					case 2: System.out.println("It has 28 days"); break;
					case 3: System.out.println("It has 31 days"); break;
					case 4: System.out.println("It has 30 days"); break;
					case 5: System.out.println("It has 31 days"); break;
					case 6: System.out.println("It has 30 days"); break;
					case 7: System.out.println("It has 31 days"); break;
					case 8: System.out.println("It has 30 days"); break;
					case 9: System.out.println("It has 31 days"); break;
					case 10: System.out.println("It has 31 days"); break;
					case 11: System.out.println("It has 30 days"); break;
					case 12: System.out.println("It has 31 days"); break;
					default: System.out.println("Not valid"); break;
				}
					break;
			default: System.out.println("Not valid"); break;
		}
	}
}
