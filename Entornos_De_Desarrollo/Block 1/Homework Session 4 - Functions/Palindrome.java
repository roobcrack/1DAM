import java.util.Scanner;

public class Palindrome{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Insert your string: ");
		String textS = sc.nextLine();
		String text = textS.toLowerCase();
		String textFinal="";

		isPalindrome(text, textFinal);	
	}

	public static void isPalindrome(String text, String textFinal){
		for(char l : text.toCharArray()){
			if(l==' '){
				continue;
			} else{
				textFinal = textFinal + l;
			}
		}

		if(isPalindrome2(textFinal)){
			System.out.println("Is palindrome");
		} else{
			System.out.println("Is not palindrome");
		}
	}

	public static boolean isPalindrome2(String text){
		String textReversed="";
		for(int i=text.length()-1; i>=0; i--){
			textReversed += text.charAt(i);
		}
		return text.equals(textReversed);
	}
}