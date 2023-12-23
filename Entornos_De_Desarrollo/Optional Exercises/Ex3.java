import java.util.Scanner;

public class Ex3{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert number: ");
		int input = sc.nextInt();

		System.out.printf("Prime numbers until %d are:", input);
	      for (int i=2;i<=input;i++) {
            int number = 2;
            while ((number < i) && (i % number != 0)){
                number++;
            }
            if (number == i) {
                System.out.printf(" %d", number);
            }
        }
	}
}
