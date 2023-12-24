import java.util.Scanner;

public class Ex7{
	public static void main(String[] args){
		enum months{JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER};
		int[] numbers = {31,28,31,30,31,30,31,31,30,31,30,31};
		Scanner sc = new Scanner(System.in);

		System.out.print("Input a month: ");
		String insert = sc.nextLine();
		months month = months.valueOf(insert.toUpperCase());

		int monthNumber = month.ordinal();
		System.out.printf("%s has %d days", insert, numbers[monthNumber]);
	}
}
