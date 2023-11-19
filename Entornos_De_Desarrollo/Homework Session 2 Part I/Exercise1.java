public class Exercise1{
	public static void main(String[] args){
		int a = 3, b = 5, c = 8;

		boolean e1 = a < 2 && b >= 5 || c == 8;
		System.out.println(e1);
		boolean e2 = a < 2 && (b >= 5 || c == 8);
		System.out.println(e2);
		boolean e3 = !(a < 2) && (b >= 5 || c == 8);
		System.out.println(e3);
	}
}