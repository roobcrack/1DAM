import java.util.Scanner;
import java.util.Random;

public class NumberGuess{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		Random rd = new Random();
		int randomNumber = 1 + rd.nextInt(50);
		int attemps = 5;

		System.out.println("Try to guess the number between 1-50");
		while(attemps>0){
			System.out.print("Try: ");
			int insert = sc.nextInt();

			if(insert==randomNumber){
				break;
			} else {
				if(insert>randomNumber){
					System.out.println("Number is lower.");
				} else{
					System.out.println("Number is higher.");
				}
				attemps--;
				System.out.printf("You have %d attemps left.", attemps);
			}
			System.out.println();
		}

		if(attemps>0){
			System.out.println("CONGRATS! YOU WON.");
		} else{
			System.out.println("You lost");
		}
	}
}