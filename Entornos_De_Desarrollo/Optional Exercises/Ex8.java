import java.util.Scanner;

public class Ex8{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int evenNumbersTotal=0, oddNumbersTotal=0;
		int numbers[] = new int[10];
		
		System.out.println("Enter 10 numbers");
		for(int i=0;i<10;i++){
			System.out.printf("%d.Insert: ",i+1);
			numbers[i] = sc.nextInt();
		}
	
		for(int i=0;i<10;i++){
			if(numbers[i]%2==0)
				evenNumbersTotal++;
			else
				oddNumbersTotal++;
		}

		int oddNumbers[] = new int [oddNumbersTotal];
		int evenNumbers[] = new int[evenNumbersTotal];
		
		int counterOdd=0, counterEven=0;
		for(int i=0;i<10;i++){
			if(numbers[i]%2==0){
				evenNumbers[counterEven] = numbers[i];
				counterEven++;
			} else{
				oddNumbers[counterOdd] = numbers[i];
				counterOdd++;
			}
		}
		printArray(evenNumbers, "even");
		System.out.println();
		printArray(oddNumbers, "odd");
	}

	static void printArray(int[] array, String type){
		System.out.printf("Here all %s numbers: ", type);
		for(int i=0; i<array.length; i++){
			System.out.printf(" %d", array[i]);
		}
	}
}
