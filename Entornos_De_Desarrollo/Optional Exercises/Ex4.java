import java.util.Scanner;

public class Ex4{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int maxNumber, minNumber, addNumber, avgNumber;
		
		int counter=0;
		do{
			System.out.print("Insert: ");
			String input = sc.nextLine();

			if(input.compareTo("end")<0){
				try{
					int numberInt = Integer.parseInt(input);
					if(counter==0){
						maxNumber=minNumber=addNumber=avgNumber=numberInt;
					} else{
						avgNumber=(avgNumber+numberInt) / 2;
						addNumber+=numberInt;
						if(minNumber>numberInt){minNumber=numberInt;}
						if(maxNumber<numberInt){maxNumber=numberInt;}
					}
					counter++;
					System.out.printf("%d.Min: %d, Max: %d, Add: %d, Avg: %d",counter, minNumber, maxNumber, addNumber, avgNumber);

				} catch(Exception e){
					System.out.println("Error");
				}
			}
		}while(input.compareTo("end")<0);
	}
}