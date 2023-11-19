import java.util.Scanner;

public class cross{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert height: ");
		int height = sc.nextInt();

		for(int i=0; i<height; i++){
			for(int j=0; j<height; j++){
				if(i==j || j==height-1-i){
					System.out.print("* ");
				} else{
					System.out.print("  ");
				}
			}
			System.out.println();
		}
	}
}