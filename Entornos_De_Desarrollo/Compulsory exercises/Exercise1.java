import java.util.Scanner;
import java.util.Random;	

//USERS ARE NAMED FROM 1 TO 10--------------------------------------------------
public class Exercise1{
	public static void main(String[] args){
		Scanner sc = new Scanner(System.in);
		int[][] usersArr = new int[5][5];
		start(usersArr);

		int input;
		do{
			System.out.println("------Menu------");
			System.out.println("1.Check if is following.");
			System.out.println("2.Check most popular user.");
			System.out.println("3.Check lonely user.");
			System.out.println("4.Check if is following.");
			System.out.println("5.Check if is following.");
			System.out.println("6.Check if is following.");
			System.out.println("7.Check if is following.");
			input = typeInput(sc, "Insert: ", "menu");

			switch(input){
				case 1: 
					int user1 = typeInput(sc, "Insert what user follows: ", "");
					int user2 = typeInput(sc, "Insert what user is followed: ", "");
					if(isFollower(usersArr, user1, user2))
						System.out.println("Yes, is following");
					else
						System.out.println("No, is not following");
					break;
				case 2: 
					System.out.println("Most popular user is user " + mostPopular(usersArr));
					break;
				case 3: 
					System.out.println("Most lonely user is user " + lonely(usersArr));
					break;
			}
			System.out.println();	
		} while(input!=0);
	}

	public static int typeInput(Scanner sc, String message, String type){
		while(true){
			try{
				System.out.print(message);
				int number = Integer.parseInt(sc.nextLine());

				if(type.equals("menu")){
					if(number<0 || number>3)
						throw new Exception("number must be higher than 0 and lower than 1");
					else
						return number;
				} else{
					if(number<=0 || number>5)
						throw new Exception("number must be higher than 0 and lower than 10");
					else
						return number;
				}
			} catch(NumberFormatException e1){
				System.err.println("Error parsing text: " + e1.getMessage());
			} catch(Exception e2){
				System.err.println("Error: " + e2.getMessage());
			}
			System.out.println();
		}
	}

	public static boolean isFollower(int[][] usersArr, int user1, int user2){
		if(usersArr[user1-1][user2-1]==1)
			return true;
		else
			return false;
	}

	public static int mostPopular(int[][] usersArr){
		return auxiliarCheck(usersArr, 0)+1;
	}

	public static int lonely(int[][] usersArr){
		return auxiliarCheck(usersArr, 5)+1;
	}

	public static int auxiliarCheck(int[][] usersArr, int initiate){
		int most = initiate;
		int higher = 0;
		for(int i=0; i<5; i++){
			int op = initiate;
			for(int j=0; j<5; j++){
				if(initiate==0){
					op += usersArr[j][i];
					if(most<op){
						most = op;
						higher = i;
					}
				} else if(initiate==5){
					op -= usersArr[j][i];
					if(op<most){
						most = op;
						higher = i;
					}
				}
			}
			System.out.println(op);
			System.out.println(" "+higher+"\n");
		}
		return higher;
	}

	public static void start(int[][] usersArr){
		Random rd = new Random();
		for(int i=0; i<5; i++){
			for(int j=0; j<5; j++){
				if(i==j){
					usersArr[i][j] = 0;
				} else{
					usersArr[i][j] = rd.nextInt(2);
				}
			}
		}

		for(int i=0; i<5; i++){
			for(int j=0; j<5; j++){
				System.out.print(usersArr[i][j] + " ");
			}
			System.out.println();
		}
	}
}