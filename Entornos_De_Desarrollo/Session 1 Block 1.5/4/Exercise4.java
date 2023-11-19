public class Exercise4
{
	public static void main(String[] args)
	{
		float pi = 3.14159f;

		System.out.print("Insert the radius of the circle: ");
		float radius = Float.parseFloat(System.console().readLine());

		System.out.printf("The area of the circle is: %f", pi * radius * radius);
	}
}