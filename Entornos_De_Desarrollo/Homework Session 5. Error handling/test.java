import java.util.Scanner;

public class CalculateDensity {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int grams = getInput(sc, "Enter weight in grams: ");
        int liters = getInput(sc, "Enter volume in liters: ");

        // Ahora puedes utilizar los valores de grams y liters según sea necesario
        System.out.println("Weight in grams: " + grams);
        System.out.println("Volume in liters: " + liters);

        sc.close();
    }

    public static int getInput(Scanner scanner, String prompt) {
        while (true) {
            try {
                System.out.print(prompt);
                int input = Integer.parseInt(scanner.nextLine());

                if (checkIfHigherThanZero(input)) {
                    return input;
                }
            } catch (NumberFormatException e) {
                System.err.println("Error: " + e.getMessage());
            }
        }
    }

    public static boolean checkIfHigherThanZero(int number) {
        if (number > 0) {
            return true;
        } else {
            throw new NumberFormatException("Number must be higher than 0");
        }
    }
}