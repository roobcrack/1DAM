import java.util.Scanner;
public class Main{
	public static void main(String[] args){
		int evenNumbersTotal, oddNumbersTotal;
		int numbers[] = new double [marks];
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter 10 numbers");
		for(int i=0;i<10;i++){
			System.out.print("Insert: ");
			numbers[i] = sc.nextInt();
		}
	}
		
	public int calculateNumber(){
			
		for(int i=0;i<10;i++){
			
		}
	}
		
		
	public void separateNumbers(){
		int oddNumbers[] = new int [oddNumbersTotal];
		int evenNumbers[] = new int[evenNumbersTotal];
			
		for(int i=0;i<10;i++){
			if(numbers[i]%2==0){
				numbers[i] = evenNumbers[i];
			}else{
				numbers[i] = oddNumbers[i];
			}
		}
		
		System.out.print("There are %d odd numbers: ", oddNumbersTotal);
		for(int i=0;i<oddNumbers.Length[];i++){
			if(i<oddNumbers.Length[]){
				System.out.print("%d, ");
			}else{
				System.out.print("%d");
			}
		}
		
		System.out.print("There are %d even numbers", evenNumbersTotal);
		for(int i=0;i<evenNumbers.Length[];i++){
			if(i<evenNumbers.Length[]){
				System.out.print("%d, ");
			}else{
				System.out.print("%d");
			}
		}
	}
}
