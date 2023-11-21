import java.util.Scanner;

public class TextEditor{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert your string: ");
		StringBuilder text = new StringBuilder(sc.nextLine());

		int option=1;
		do{
			System.out.println("Choose what you want to do.(0 to exit)");
			System.out.println("1. Add text(choose)");
			System.out.println("2. Append text(end)");
			System.out.println("3. Insert text(beginning)");
			System.out.println("4. Delete text(choose)");
			System.out.print("Insert: ");
			option = sc.nextInt();

			switch(option){
				case 0: System.out.println("Leaving the program..."); break;
				case 1: 
			}
		} while(option != 0);
	}
}