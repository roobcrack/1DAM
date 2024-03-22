import java.util.Stack;
import java.util.Scanner;

public class Main {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        Stack<String> myStack = new Stack<>();

        String insert = sc.nextLine();
        while(insert != ""){
            myStack.push(insert);
            insert = sc.nextLine();
        }

        while(!myStack.empty()){
            System.out.println(myStack.pop());
        }
    }
}
