import java.util.Scanner;
public class Main{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int evenNumbersTotal=2, oddNumbersTotal=2;
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
		
		for(int i=0;i<10;i++){
			int counterOdd=0, counterEven=0;
			if(numbers[i]%2==0){
				evenNumbers[counterEven] = numbers[i];
				counterEven++;
			} else{
				oddNumbers[counterOdd] = numbers[i];
				counterOdd++;
			}
		}

		System.out.print("Here all even numbers: ");
		for(int i=0; i<evenNumbers.Length(); i++){
			System.out.printf(" %d", numbers[i]);
		}
	}
}
