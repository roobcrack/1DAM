import java.util.Scanner;

public class WaitApp{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		while(true){
			try{
				System.out.print("Insert seconds: ");
				int seconds = Integer.parseInt(sc.nextLine());

				if(seconds>0){
					break;
				} else{
					throw new Exception("number must be higher than 0");
				}
			} catch(NumberFormatException e1){
				System.err.println("Error parsing text: " + e1.getMessage());
			} catch(Exception e2){
				System.err.println("Error: " + e2.getMessage());
			}
		}
	}
}