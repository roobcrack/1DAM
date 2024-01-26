import java.util.Scanner;

public class CountOcurrences{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		System.out.println("Is \"b\" contained \"n\" times in \"a\"");
		System.out.print("Phrase a: ");
		String a = sc.nextLine();
		System.out.print("Phrase b: ");
		String b = sc.nextLine();
		System.out.print("Insert: ");
		int n = sc.nextInt();
		//if(){
			System.out.println(countString(a, b, n));
		//}
	}

	public static String countString(String a, String b, int n){
		int index = 0;
		int returnS;
		while(index!=a.length()){
			//System.out.println(a(index, (b.length()+index)));
			if(a.equalsIgnoreCase(b)){
				returnS="Si";
			} else{
				returnS="No";
			}
		}
		return returnS;
	}
}