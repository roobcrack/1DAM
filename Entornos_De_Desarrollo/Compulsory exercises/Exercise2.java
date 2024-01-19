import java.util.Scanner;


public class Exercise2{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		String[] ingredientsNames = {"water", "coffee", "cup", "decaffeinated coffee", "powdered milk", "powdered cream" };
		int[] ingredientsAmmount = { 5, 4, 4, 3, 2, 1 };
		int[] ingredientsUsed = new int[3];
		int insert=-1, sugar, money;

		do{
			boolean done = false;
			while(!done){
				System.out.println("1.Coffee");
				System.out.println("2.Decaffeinated");
				System.out.print(" Insert: ");
				try{
					insert = Integer.parseInt(sc.nextLine());
				} catch(Exception e){
					System.out.println("Error text parsing: "+e.getMessage());
				}
				if(insert>=0 && insert <=2)
					done=true;
				else
					System.out.println("Error number range: number must be from 0 to 2");
			}
			switch(insert){
				case 1: 
					ingredientsUsed = new int[] {0, 1, 2};
					break;
				case 2: 
					ingredientsUsed = new int[] {0, 3, 2};
					break;
			}

			if(insert==0)
				System.out.println("Closing program...");
			else if(checkIfIngredients(ingredientsNames, ingredientsAmmount, ingredientsUsed)!=null)
				System.out.println("EMPTY: "+checkIfIngredients(ingredientsNames, ingredientsAmmount, ingredientsUsed));
			else{
				System.out.println("Insert the amount of sugar from 0-5");
				System.out.print("	Insert: ");
				sugar = Integer.parseInt(sc.nextLine());

				System.out.println("Insert money");
				System.out.print("Insert: ");
				money = Integer.parseInt(sc.nextLine());
				if(money>1)
					System.out.println("Change is: "+returnChange(money-1));
				else if(money==1)
					System.out.println("There is no change :)");
				preparateCoffee(ingredientsAmmount, ingredientsUsed);
			}
		} while(insert!=0);
	}

	public static String checkIfIngredients(String[] ingredientsNames, int[] ingredientsAmmount, int[] ingredientsUsed){
		for(int i=0; i<ingredientsUsed.length; i++){
			if(ingredientsAmmount[ingredientsUsed[i]]<=0)
				return ingredientsNames[ingredientsUsed[i]];
		}
		return null;
	}

	c v public static String returnChange(int money){
		String finalString="";
		int[] billsAndCoins = {20, 10, 5, 2, 1};

		for (int ammount : billsAndCoins) {
		    while (money >= ammount) {
		        money -= ammount;
		        finalString += ammount + " ";
		    }
		}
		return finalString;
	}

	public static void preparateCoffee(int[] ingredientsAmmount, int[] ingredientsUsed){
		for(int i=0; i<ingredientsUsed.length; i++)
			ingredientsAmmount[ingredientsUsed[i]]--;
	}

	public static void printMachine(){
		for(int i=0; i<5; i++){
		
        }
	}
}