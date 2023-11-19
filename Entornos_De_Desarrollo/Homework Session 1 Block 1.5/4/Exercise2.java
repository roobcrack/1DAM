import java.util.Scanner;

public class Exercise2
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Insert grams: ");
		float grams = sc.nextFloat();
		float ounce = grams * 28.3495f;

		System.out.printf("%f grams are: %f ounces", grams, ounce);


	}
}