import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner((System.in));
        Map<String, String> myMap = new HashMap<>();

        String exit;
        do{
            System.out.print("ID: ");
            String id = sc.nextLine();
            System.out.print("Title: ");
            String title = sc.nextLine();
            System.out.print("Authors name: ");
            String author = sc.nextLine();
            System.out.println("Want to add a new one(y for yes, anything else for no)");
            exit = sc.nextLine();
        } while (exit.equals("y"));

        for (Map book : myMap.values()) {
            System.out.println(book);
        }
    }
}
