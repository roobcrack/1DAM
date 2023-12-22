import java.util.Scanner;

public class Ex3{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert number: ");
		int number = sc.nextInt();

		System.out.printf("Prime numbers until %d are:", number);
		for(int i=2;i<=number;i++){
			for (int j=2;j<=Math.sqrt(i);j++) {
	            if (i % j != 0) {
	                System.out.printf(" %d",j);
	            }
	        }
	    }
	}
}
