import java.util.Scanner;

public class Ex5{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		
		System.out.println("How many marks are you going to introduce?");
		System.out.print("Insert: ");
		int marks = sc.nextInt();

		int[] numbers = new int[marks];
		marksEnter(sc, numbers, marks);

		System.out.printf("The average is: %d. The marks greater than average are: ", averageNumber(numbers, marks));
		for(int i=0; i<marks; i++){
			if(numbers[i]>averageNumber(numbers, marks))
				System.out.printf(" %d", numbers[i]);
		}
	}
	
	public static void marksEnter(Scanner sc, int[] numbers, int marks){
		System.out.println("Now insert the numbers");
		for(int i=0;i<marks;i++){
			System.out.print("Insert: ");
			numbers[i] = sc.nextInt();
		}
	}
	
	public static int averageNumber(int[] numbers, int marks){
		int total=0;
		
		for(int i=0;i<marks;i++){
			total = total + numbers[i]; 
		}
		return total/marks;
	}
}
