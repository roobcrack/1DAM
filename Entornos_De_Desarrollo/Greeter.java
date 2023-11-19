import java.util.Scanner;

public class Greeter{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int language;

		System.out.println("1-Spanish | 2-English | 3-Valencian | 4-Italian | 5-German");
		System.out.print("Select the language: ");
		language = sc.nextInt();

		switch(language){
		case 1: System.out.println("Hola, ¿cómo estás?"); break;
		case 2: System.out.println("Hello, how are you?"); break;
		case 3: System.out.println("Hola, com va?"); break;
		case 4: System.out.println("Ciao, come stai?"); break;
		case 5: System.out.println("Hallo, wie geht es dir?"); break;
		default: System.out.println("Not founded");
		}
	}
}