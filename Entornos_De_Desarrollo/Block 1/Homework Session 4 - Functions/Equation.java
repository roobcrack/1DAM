import java.util.Scanner;

public class Equation{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.println("Now insert a, b and c for the equation.");
		System.out.print("A: ");
		int a = sc.nextInt();
		System.out.print("B: ");
		int b = sc.nextInt();
		System.out.print("C: ");
		int c = sc.nextInt();

		System.out.print(calculateEquation(a, b, c));
	}

	public static double calculateEquation(int a, int b, int c){
		return -b+Math.sqrt(((Math.pow(b, 2)-4)*a*c)/(2*a));
	}
}