import java.util.Scanner;

public class Triangle{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert the base of the triangle: ");
		int base = sc.nextInt();
		int spaces=base;

		for(int i=0; i<base; i++){
			for(int j=base; j>0; j--){
				if(j>spaces){
					System.out.print(" ");
				} else{
					System.out.print("*");
				}
			}
			System.out.println();
			spaces--;
		}
	}
}