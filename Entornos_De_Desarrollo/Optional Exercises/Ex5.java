import java.util.Scanner;
public class Ex5{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		
		System.out.println("How many marks are you going to introduce?");
		System.out.print("Insert: ");
		int marks = sc.nextInt();

		int[] numbers = new int[marks];
		marksEnter(sc, numbers, marks);

		System.out.printf("The average is: %d. The mark greater than average is %d.", averageNumber(numbers, marks), greaterNumberCalc(numbers, marks));
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
	
	public static int greaterNumberCalc(int[] numbers, int marks){
		int greaterNumber = numbers[0];
		
		for(int i=0;i<marks;i++){
			if(greaterNumber<numbers[i]){
				greaterNumber = numbers[i];
			}
		}
		return greaterNumber;
	}
}
