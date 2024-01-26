import java.util.Scanner;

public class Ex4{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int maxNumber=0, minNumber=0, addNumber=0, avgNumber=0, count=0;
		String input;

		do{
			System.out.print("Insert: ");
			input = sc.nextLine();

			if(input.compareTo("end")<0){
				try{
					int numberInt = Integer.parseInt(input);
					if(count==0){
						maxNumber=numberInt;
						minNumber=numberInt;
					}
					count++;
					addNumber+=numberInt;
					avgNumber=addNumber/count;
					if(minNumber>numberInt){minNumber=numberInt;}
					if(maxNumber<numberInt){maxNumber=numberInt;}
					System.out.printf("%d.Min: %d, Max: %d, Add: %d, Avg: %d\n", count, minNumber, maxNumber, addNumber, avgNumber);

				} catch(Exception e){
					System.out.println("Error");
				}
			}
		}while(input.compareTo("end")<0);
	}
}