import java.util.LinkedList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        LinkedList<Person> list = new LinkedList<>();
        Person person;

        String name;
        do {
            System.out.print("Insert name: ");
            name = sc.nextLine();
            if (!name.equals("")) {
                System.out.print("Insert age: ");
                int age;
                while (true) {
                    String ageInput = sc.nextLine();
                    try {
                        age = Integer.parseInt(ageInput);
                        break;
                    } catch (NumberFormatException e) {
                        System.out.println("Invalid input. Please enter a valid age: ");
                    }
                }

                person = new Person(name, age);
                list.add(person);
            }
        } while (!name.equals(""));

        System.out.println("Persons 18 years or older:");
        for (Person p : list) {
            if (p.getAge() >= 18)
                System.out.println(p);
        }
    }
}