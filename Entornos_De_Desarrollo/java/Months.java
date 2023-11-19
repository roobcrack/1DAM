import java.util.Scanner;

public class Months{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
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
	}
}