import java.util.Scanner;

public class Exercise2{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		String[] ingredientsNames = {"water", "coffee", "cup", "decaffeinated coffee", "powdered milk", "powdered cream" };
		int[] ingredientsAmmount = { 5, 4, 4, 3, 2, 1};
		int[] ingredientsUsed = new int[3];
		int insert, sugarAmount, money;

		do{
			do{
				try{
					System.out.println("1.Coffee");
					System.out.println("2.Decaffeinated");
					System.out.print(" Insert: ");
					
					insert = Integer.parseInt(sc.nextLine());
					if(insert<1 || insert > 2)
						throw new Exception("insert a valid number");
				} catch(Exception e){
					System.out.println("Error text parsing: "+e.getMessage());
				}
			} while (insert < 1 || insert > 2);
			switch(insert){
				case 1: 									//Coffee
					ingredientsUsed = new int[] {0, 1, 2};
					break;
				case 2: 									//Decaffeinated
					ingredientsUsed = new int[] {0, 3, 2};
					break;
			}

			if(insert==0)
				System.out.println("Closing program...");
			else if(checkIfIngredients(ingredientsNames, ingredientsAmmount, ingredientsUsed)!=null)
				System.out.println("EMPTY: "+checkIfIngredients(ingredientsNames, ingredientsAmmount, ingredientsUsed));
			else{
                do{
                    try{
                        System.out.println("Insert the amount of sugar from 0-5");
                        System.out.print("  Insert: ");
                        sugarAmount = Integer.parseInt(sc.nextLine());
                        if(sugarAmount>5 || sugarAmount <0)
                            throw new Exception("ammount must be from 0-5");
                    } catch(Exception e){
                        System.out.println("Error: "+e.getMessage());
                    }
                } while(sugarAmount>5 || sugarAmount <0);

                do{
                    try{
                        System.out.println("Insert money");
                        System.out.print(" Insert: ");
                        money = Integer.parseInt(sc.nextLine()); 

	                    if(money > 20 || money < 1)
	                        throw new Exception("insert must be max: 20 & min: 1");
	                    else if(money==1)
	                        System.out.println("There is no change");
	                    else
	                        System.out.println("Change is: "+returnChange(money-1));
	                } catch(Exception e){
                        System.out.println("Error: "+e.getMessage());
                    }
                } while(money<=20 && money>=1);
                preparateCoffee(ingredientsAmmount, ingredientsUsed);
		} while(insert!=0);
	}

	public static String checkIfIngredients(String[] ingredientsNames, int[] ingredientsAmmount, int[] ingredientsUsed){
		for(int i=0; i<ingredientsUsed.length; i++){
			if(ingredientsAmmount[ingredientsUsed[i]]<=0)
				return ingredientsNames[ingredientsUsed[i]];
		}
		return null;
	}

	public static String returnChange(int money){
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

	public static void preparateCoffee(Scanner sc, int[] ingredientsAmmount, int[] ingredientsUsed){
		for(int i=0; i<ingredientsUsed.length; i++)
			ingredientsAmmount[ingredientsUsed[i]]--;
	}
}