import java.util.Scanner;

public class MatrixAddition{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int[][] matrixA = new int[3][3];
		int[][] matrixB = new int[3][3];
		int[][] result = new int[3][3];

		System.out.println("Matrix A");
		for(int i=0; i<3; i++){
			for(int j=0; j<3; j++){
				System.out.printf("Insert %d,%d: ", (i+1), (j+1));
				matrixA[i][j] = sc.nextInt();
			}
		}
		System.out.println();

		System.out.println("Matrix B");
		for(int i=0; i<3; i++){
			for(int j=0; j<3; j++){
				System.out.printf("Insert %d,%d: ", (i+1), (j+1));
				matrixB[i][j] = sc.nextInt();
			}
		}
		System.out.println();

		System.out.println("Result");
		for(int i=0; i<3; i++){
			System.out.print("{ ");
			for(int j=0; j<3; j++){
				result[i][j] = matrixA[i][j] + matrixB[i][j];
				System.out.printf("%d ", result[i][j]);
			}
			System.out.println("}");
		}
	}
}