import java.util.Scanner;

public class MarkCount{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int[] marks = new int[10];

		for(int i=0; i<10; i++){
			System.out.printf("Insert %d: ", (i+1));
			marks[i] = sc.nextInt();
		}
		System.out.println();

		for(int i=0; i<=10; i++){
			int counter = 0;
			for(int j=0; j<10; j++){
				if(marks[j] == i){
					counter++;
				}
			}
			System.out.printf("%d: %d marks", i, counter);
			System.out.println();
		}
		
	}
}