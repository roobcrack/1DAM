import java.util.Scanner;

public class MonthEnum{
	enum month{ January, February, March, April, May, June, July, August, 
	September, October, November, December }

	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int[] monthsDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		
		System.out.print("Insert a number of a month (1-12): ");
		int number = sc.nextInt();
		month monthDay = month.values()[number-1];

		System.out.printf("%s has %d days", monthDay, monthsDays[number-1]);
	}
}