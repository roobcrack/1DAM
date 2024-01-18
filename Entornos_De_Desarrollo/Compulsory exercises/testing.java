public class testing{
	public static void main(String[] args){
		//45
		System.out.println("   _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _  ");
		System.out.println(" /                                           \\");
		System.out.println("|                                             |");
		System.out.println("|          Insert yout coffee                 |");
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
		System.out.printf("|%s%s%s|\n",spaces,spaces,odd);
		System.out.printf("|%s%s%s%s|\n",spaces,text1,spaces,odd);
		System.out.printf("|%s%s%s|\n",spaces,spaces,odd);
		System.out.printf("|%s%s%s%s|\n",spaces,text2,spaces,odd);
		System.out.printf("|%s%s%s%s|\n",spaces,text3,spaces,odd);
		System.out.printf("|%s%s%s%s|\n",spaces,text4,spaces,odd);
		System.out.printf("|%s%s%s%s|\n",spaces,text5,spaces,odd);

		int x = 5;
    int y = 10;

    // Mueve el cursor a la posición (x, y)
    System.out.print("\033[" + y + ";" + x + "H");

    System.out.println("Hola, mundo!");
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