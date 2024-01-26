import java.util.Scanner;

public class Square{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert square height: ");
		int height = sc.nextInt();

		for(int i=0; i<height; i++){
			for(int j=0; j<height; j++){
				if(j==height/2+i || j==height/2-i){
					System.out.print("* ");
				} else{
					System.out.print("  ");
				}
			}
			System.out.println();
		}
	}
}