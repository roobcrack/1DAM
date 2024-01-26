import java.util.Scanner;

public class LispChecker{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int opened=0;

		System.out.print("Insert text with parentheses: ");
		String text = sc.nextLine();

		for(int i=0; i<text.length(); i++){
			if(text.charAt(i)=='('){
				opened++;
			} else if(text.charAt(i)==')'){
				opened--;
			}
		}

		if(opened==0){
			System.out.println("The text is correct");
		} else{
			System.out.println("The text is wrong");
		}
	}
}