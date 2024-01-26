import java.util.Scanner;

public class CheckMessages{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		String[] phrases = new String[10];

		System.out.println("Insert 10 phrases");
		for(int i=0; i<10; i++){
			System.out.printf("%d: ", (i+1));
			phrases[i] = sc.nextLine();
			phrases[i] = phrases[i].replace("Eclipse", "IntelliJ");
		}

		System.out.println();
		for(int i=0; i<10; i++){
			System.out.printf("%d: %s\n", (i+1), phrases[i]);
		}
	}
}