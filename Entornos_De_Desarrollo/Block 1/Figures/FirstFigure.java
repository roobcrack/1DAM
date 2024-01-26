import java.util.Scanner;

public class FirstFigure{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert cross length: ");
		int insert = sc.nextInt();

		for(int i=0; i<insert; i++){
			for(int j=0; j<insert; j++){
				if(i == (insert/2) || (i == (insert/2)-1 && insert % 2 == 0)){
					System.out.print("* ");
				} else if(j == (insert/2) || (j == (insert/2)-1 && insert % 2 == 0)){
					System.out.print("* ");
				} else{
					System.out.print("  ");
				}
			}
		System.out.println();
		}
	}
}