public class Exercise3
{
	public static void main(String[] args)
	{
		System.out.print("Insert a number: ");
		String number1 = System.console().readLine();
		System.out.print("Insert a second number: ");
		String number2 = System.console().readLine();
		System.out.print("Insert a third number: ");
		String number3 = System.console().readLine();
		System.out.print("Insert a forth number: ");
		String number4 = System.console().readLine();

		int number12 = Integer.parseInt(number1 + number2);
		int number34 = Integer.parseInt(number3 + number4);

		int result = number12 + number34;
		System.out.printf("Result is: %d", result);
	}
}