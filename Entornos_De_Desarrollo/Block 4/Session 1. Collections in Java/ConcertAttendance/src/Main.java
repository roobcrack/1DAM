import java.util.LinkedList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        LinkedList<Person> list = new LinkedList<>();
        Person person = null;

        String name = "";
        do {
            System.out.println("Insert name: ");
            name = sc.nextLine();
            if(name != "") {
                System.out.println("Insert age: ");
                int age = sc.nextInt();

                person = new Person(name, age);
                list.add(person);
            }
        } while(name != "");

        while(list.size() > 0){
            if(person.getAge()>=18)
                System.out.println(list.remove());
            else
                list.remove();
        }
    }
}
