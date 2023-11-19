import java.util.Scanner;

public class GramOunceConverter2{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		float ounces = 28.3495f;

		System.out.println("Choose what you want to change");
		System.out.print("o ->ounces to grams; g ->grams to ounces: ");
		String type = sc.nextLine();

		System.out.print("Insert ammount: ");
		float number = sc.nextFloat();

		if(type == "o"){
			System.out.println("It is %f grams", number / ounces);
		}else if(type == "g"){
			System.out.println("It is %f ounces", number * ounces);
		}else{
			System.out.println("Type not founded");
		}
	}
}