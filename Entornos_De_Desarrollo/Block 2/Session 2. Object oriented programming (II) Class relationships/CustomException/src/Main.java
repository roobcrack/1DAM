public class Main {
    public static void main(String[] args) {
        try {
            int result = positiveSubtract(5, 8);
            System.out.println("Result: " + result);
        } catch (NegativeSubtractException e) {
            System.out.println(e.getMessage());
        }
    }

    public static int positiveSubtract(int n1, int n2) throws NegativeSubtractException {
        int result = n1 - n2;
        if (result < 0) {
            throw new NegativeSubtractException(n1, n2);
        }
        return result;
    }
}