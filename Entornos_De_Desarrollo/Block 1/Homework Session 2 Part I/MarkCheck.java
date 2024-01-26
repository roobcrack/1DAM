import java.util.Scanner;

public class MarkCheck{
	public static void main(String[] arg){
		Scanner sc = new Scanner(System.in);
		int numero = 2;

		System.out.print("Insert a number: ");
		int number1 = sc.nextInt();
		System.out.print("Insert a number: ");
		int number2 = sc.nextInt();
		System.out.print("Insert a number: ");
		int number3 = sc.nextInt();
		
		if((number1 >= 4) && (number2 >= 4) && (number3 >= 4)){
			System.out.println("All marks are greater than 4");
		}else if((number1 < 4) && (number2 < 4) && (number3 < 4)){
			System.out.println("No mark is greater or equal than 4");
		}else{
			System.out.println("Some marks are not greater or equal than 4");
		}
	}
}