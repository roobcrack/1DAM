import java.util.Scanner;

public class StudentMarksProgram {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Get the number of students and marks from the user
        System.out.print("Enter the number of students: ");
        int numStudents = scanner.nextInt();

        // Create arrays to store names and marks
        String[] names = new String[numStudents];
        int[] marks = new int[numStudents];

        // Get names and marks from the user
        System.out.println("Enter the names and marks in the same line (space-separated):");
        for (int i = 0; i < numStudents; i++) {
            names[i] = scanner.next();
            marks[i] = scanner.nextInt();
        }

        // Calculate the average of the marks
        double sum = 0;
        for (int mark : marks) {
            sum += mark;
        }
        double average = sum / numStudents;

        System.out.println("Average Mark: " + average);

        // Display names of students with marks greater than the average
        System.out.println("Names of students with marks greater than the average:");
        for (int i = 0; i < numStudents; i++) {
            if (marks[i] > average) {
                System.out.println(names[i]);
            }
        }

        // Find the name of the student with the highest mark
        int maxMarkIndex = 0;
        for (int i = 1; i < numStudents; i++) {
            if (marks[i] > marks[maxMarkIndex]) {
                maxMarkIndex = i;
            }
        }

        System.out.println("Student with the highest mark: " + names[maxMarkIndex]);

        // Close the scanner
        scanner.close();
    }
}
