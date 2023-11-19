import java.util.Scanner;

public class SortJoin{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.println("Insert names separated by one space");
		String namesInsert = sc.nextLine();

		String[] names = namesInsert.split(" ");

		for(int i=0; i<(names.length-1); i++){
			String nameSaved;

			for(int j=i+1; j<names.length; j++){
				if(names[i].compareTo(names[j]) > 0){
					nameSaved = names[i];
					names[i] = names[j];	
					names[j] = nameSaved;
				}
			}	
		}

		System.out.printf("%s", String.join(", ", names));
	}
}