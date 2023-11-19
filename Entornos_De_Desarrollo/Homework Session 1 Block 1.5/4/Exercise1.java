import java.util.Scanner;

public class Exercise1
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert day of birth: ");
		int dayBirth = sc.nextInt();
		System.out.print("Insert month of birth: ");
		int monthBirth = sc.nextInt();
		System.out.print("Insert year of birth: ");
		int yearBirth = sc.nextInt();

		System.out.printf("%d/%d/%d", dayBirth, monthBirth, yearBirth);
	}
}