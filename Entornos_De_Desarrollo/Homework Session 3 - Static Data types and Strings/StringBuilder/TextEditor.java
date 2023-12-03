import java.util.Scanner;

public class TextEditor{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		String textAdd;
		System.out.print("Insert your string: ");
		StringBuilder text = new StringBuilder(sc.nextLine());

		int option;
		do{
			System.out.printf("---Your text: %s---\n", text);
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
					System.out.printf("Insert number where you want to modify (1-%d): ", text.length());
					int position = sc.nextInt();
					System.out.println("Now insert the string: ");
					textAdd = sc.nextLine();
					text.insert(position-1, textAdd);
					break;
					
				case 2: 
					System.out.print("Insert the string: ");
					textAdd = sc.nextLine();
					text.append(textAdd);
					break;

				case 3: 
					System.out.print("Insert the string: ");
					textAdd = sc.nextLine();
					text.insert(0, textAdd);
					break;

				case 4: 
					System.out.println("");
					break;

				default: System.out.println("Not founded option."); break;
			}
		} while(option != 0);
	}
}