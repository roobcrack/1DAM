import java.util.Scanner;

public class Palindrome{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Insert your string: ");
		String text = sc.nextLine();
<<<<<<< HEAD
		if(isPalindrome(text)){
			System.out.println("Is palindrome");
		} else{
			System.out.println("Is not palindrome");
=======
		isPalindrome(text, textFinal);		
	}

	public static void isPalindrome(String text, String textFinal){
		for(char l : text){
			if(l==' '){
				l.parse
				continue;
			} else{
				textFinal = textFinal + l;
			}
>>>>>>> 39efcd62ada9bc6ba0ff025a7d46134f57c2664a
		}
	}

	public static boolean isPalindrome(String text){
		String textReversed="";
		for(int i=text.length()-1; i>=0; i--){
			textReversed += text.charAt(i);
		}
		return text.equals(textReversed);
	}
}