import java.util.Scanner;

public class Counter{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert a number between 1-100: ");
		int number = sc.nextInt();

		if(number < 1 || number > 100){
			System.out.println("Wrong insert");
		} else{
			for(int i=number; i>0; i--){
				System.out.println(number);
				number--;
			}
		}
	}
}