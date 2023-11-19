import java.util.Scanner;

public class GroupPeople{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int fifty=0, ten=0, one=0;

		System.out.print("How many people will attend: ");
		int people = sc.nextInt();

		while(people>0){
			if(people>=50){
				people=-50;
				fifty++;
			} else if(people>=10){
				people=-8;
				ten++;
			} else{
				people--;
				one++;
			}
		}
		System.out.println(fifty);
		System.out.println(ten);
		System.out.println(one);
	}
}