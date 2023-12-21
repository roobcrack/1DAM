import java.util.Scanner;
public class Main{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int maxNumber, minNumber, addNumber=0, avgNumber=0;
		String input;
		
		do{
			System.out.print("Insert: ");
			input = sc.nextLine();
			if(addNumber==0){ maxNumber = number(input); minNumber= number(input); }
		}while(input!="end");
	}

	static int number(String input){
		return Integer.parseInt(input);
	}

	static void checkNumber(){
		
	}
}
