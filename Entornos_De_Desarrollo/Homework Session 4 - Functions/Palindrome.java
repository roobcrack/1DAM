import java.util.Scanner;

public class Palindrome{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.print("Insert your string: ");
		String text = sc.nextLine();
		if(isPalindrome(text)){
			System.out.println("Is palindrome");
		} else{
			System.out.println("Is not palindrome");
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