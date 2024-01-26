import java.util.Scanner;

public class Divisors{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
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
	}
}