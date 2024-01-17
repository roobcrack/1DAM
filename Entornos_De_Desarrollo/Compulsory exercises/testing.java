public class testing{
	public static void main(String[] args){
		//45
		System.out.println("   _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _  ");
		System.out.println(" /                                           \\");
		System.out.println("|                                             |");
		System.out.printf("|%s%s%s%s|\n", spaces, text, spaces, odd);
		System.out.println("|                                             |");
		System.out.println("|                                             |");
		System.out.println("|         1.Coffee                            |");
		System.out.println("|         2.Decaffeinated                     |");
		System.out.println("|                                             |");
		System.out.println("|                                             |");
		System.out.println("|                  Insert:                    |");
		System.out.println(" \\ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ /");
		System.out.println("adadasdasdasdadasd");
	menu();
	}

	public static void menu(){
		String odd = "";
		String text = "Choose your coffeeeeeeeeeeeeeeeeeeee";
		if(text.length()%2==0)
			odd =" ";
		int numberSpaces = (45-text.length())/2;
		String spaces = " ".repeat(numberSpaces);
		//---
		System.out.printf("  %s\n", " _".repeat(21));
		System.out.printf(" /%s \\\n", "  ".repeat(21));
		System.out.printf("|%s%s%s%s|\n",spaces,text,spaces,odd);
	}
}

/*

  |         |
  |         |
  |         |
  |         |
  \         /
   \       /
    \     /
     - - - 
*/