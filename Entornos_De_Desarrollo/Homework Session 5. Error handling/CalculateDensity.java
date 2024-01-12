import java.util.Scanner;

public class CalculateDensity{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		int grams = typeInput(sc, "Enter weight in grams: ");
		int liters = typeInput(sc, "Enter volume in liters: ");

		try{
			double result = (double)grams / liters;
			System.out.println("The density is: " + result);
		} catch(ArithmeticException e){
			System.err.println("Error: " + e.getMessage());
		}
	}

	public static int typeInput(Scanner sc, String message){
		while(true){
			try{
				System.out.print(message);
				int number = Integer.parseInt(sc.nextLine());
				if(number>0)
					return number;
				else
					throw new Exception("number must be higher than 0");
			} catch(NumberFormatException e1){
				System.err.println("Error parsing text: " + e1.getMessage());
			} catch(Exception e2){
				System.err.println("Error: " + e2.getMessage());
			}
		}
	}

}