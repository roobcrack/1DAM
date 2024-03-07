import java.util.Scanner;
import java.util.Random;

//USERS ARE NAMED FROM 1 TO 10--------------------------------------------------
public class Main{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int[][] usersArr = new int[10][10];
        int[] group = { 1, 2, 4 };
        createAndPrintMatrix(usersArr);

        System.out.println("----------isFollowing----------");
        System.out.println("True- Is follower is: "+isFollower(usersArr, 1, 2));
        System.out.println("False- Is follower is: "+isFollower(usersArr, 1, 6));
        isFollower(usersArr, 11, 2);
        System.out.println("-------------------------------");
        System.out.println("----------mostPopular----------");
        System.out.println("Most popular user is: "+(mostPopular(usersArr)));
        System.out.println("-------------------------------");
        System.out.println("------------lonely-------------");
        System.out.println("Lonely user is: "+(lonely(usersArr)));
        usersArr[7][5] = 1;
        System.out.println("None lonely user: "+(lonely(usersArr)));
        System.out.println("-------------------------------");
        System.out.println("-----------isGroup-------------");
        System.out.println("True- Are they a grop: "+(isGroup(usersArr, group)));
        int[] group2 = { 1, 2, 5 };
        System.out.println("False- Are they a grop: "+(isGroup(usersArr, group2)));
        int[] group3 = { 13, 2, 5 };
        isGroup(usersArr, group3);
    }

    public static boolean isFollower(int[][] usersArr, int user1, int user2){
        try{
            return usersArr[user1 - 1][user2 - 1] == 1;
        } catch(NumberFormatException e1){
            System.err.println("Error parsing text: "+e1.getMessage());
        } catch(ArrayIndexOutOfBoundsException e2){
            System.err.println("Error: "+e2.getMessage());
        }
        return false;
    }

    public static int mostPopular(int[][] usersArr){
        try{
            int higher = 0;
            for(int i=0; i<10; i++){
                int sum=0;
                for(int j=0; j<10; j++)
                    sum += usersArr[j][i];
                if(higher<sum)
                    higher = i;
            }
            return higher;
        } catch(NumberFormatException e1){
            System.err.println("Error parsing text: "+e1.getMessage());
        } catch(ArrayIndexOutOfBoundsException e2){
            System.err.println("Error: "+e2.getMessage());
        }
        return 0;
    }

    public static int lonely(int[][] usersArr){
        for(int i=0; i<10; i++){
            int sum=0;
            for(int j=0; j<10; j++)
                sum += usersArr[j][i];
            if(sum==0)
                return i;
        }
        return -1;
    }

    public static boolean isGroup(int[][] usersArr, int[] group){
        try{
            for(int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    if(!(isFollower(usersArr, group[i], group[j])) || i!=j)
                        return false;
                }
                if(i==2)
                    return true;
            }
        } catch(NumberFormatException e1){
            System.err.println("Error parsing text: "+e1.getMessage());
        } catch(ArrayIndexOutOfBoundsException e2){
            System.err.println("Error: "+e2.getMessage());
        }
        return false;
    }

    public static void createAndPrintMatrix(int[][] usersArr){
        Random rd = new Random();
        for(int i=0; i<10; i++){
            for(int j=0; j<10; j++){
                if(i==j || j==5)
                    usersArr[i][j] = 0;
                else if(i==0 && (j==1 || j==3) || i==1 && (j==0 || j==3) || i==3 && (j==0 || j==1))
                    usersArr[i][j] = 1;
                else
                    usersArr[i][j] = rd.nextInt(2);
            }
        }

        for(int i=0; i<10; i++){
            for(int j=0; j<10; j++)
                System.out.print(usersArr[i][j] + " ");
            System.out.println();
        }
        System.out.println();
    }
}