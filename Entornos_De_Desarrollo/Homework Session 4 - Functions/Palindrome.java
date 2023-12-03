import java.util.Scanner;

public class Palindrome{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		String textFinal;
		System.out.print("Insert your string: ");
		String text = sc.nextLine();
		isPalindrome(text, textFinal);

		
	}

	public static void isPalindrome(String text, String textFinal){
		for(char l : text){
			if(l==' '){
				continue;
			} else{
				textFinal = textFinal + l;
			}
		}
	}
}