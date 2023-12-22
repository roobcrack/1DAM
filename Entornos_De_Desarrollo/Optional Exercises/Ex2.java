import java.util.Scanner;
public class Ex2{
	public static void main(String[] args){
		System.out.println("Insert numbers until you insert 0");
		askNumbers();
	}
		
	public static void askNumbers(){
		Scanner sc = new Scanner(System.in);
		int number=1, counter=0;

		//Ask for number
		while(number!=0){
			System.out.print("Insert: ");
			number = sc.nextInt();
			
			//Count how many times
			if(number!=0)	
				counter++;
		}

		//Print outputs number
		System.out.printf("The number of inputs is: %d", counter);
	}
}
