import java.util.Scanner;

public class Ex1{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int number, result;

		//Ask for number
		System.out.print("Insert one number: ");
		number = sc.nextInt();
		
		System.out.printf("The first %d squared numbers are: ",number);
		//Print the values
		for(int i=1;i<=number;i++){
			System.out.print(i*i);
			if(i<number)
				System.out.print(", ");
		}
	}
}
