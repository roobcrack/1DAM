import java.util.Scanner;

public class CalculateDensity{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		try{
			System.out.print("Enter weight in grams: ");
			int grams = sc.nextInt();

			System.out.print("Enter volume in liters: ");
			int liters = sc.nextInt();
		//NumberFormatException doesn't work for the exercice.
		}catch(Exception e){
			System.out.println("ERROR. IMPUT NOT VALID");
		}
	}
}