import java.util.Scanner;

public class Ex6{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);

		System.out.print("Insert number of students: ");
		int number = sc.nextInt();

		String[] studentsName = new String[number];
		double[] studentsMarks = new double[number];

		System.out.println("Insert name and then mark: ");
		for(int i=0;i<number;i++){
			studentsName[i] = sc.next();
			studentsMarks[i] = sc.nextDouble();
		}

		double avg=0;
		for(int i=0;i<number;i++)
			avg += studentsMarks[i];
		avg = avg/number;

		int greatest=0;
		System.out.println("The students with marks greater than the average are:");
        for (int i=0;i<number;i++) {
            if (studentsMarks[i] > avg) {
                System.out.printf("- %s\n", studentsName[i]);
                if(studentsMarks[greatest]<studentsMarks[i])
                	greatest=i;
            }
        }

        System.out.printf("The student with the greatest mark is: ", studentsName[greatest]);
	}
}