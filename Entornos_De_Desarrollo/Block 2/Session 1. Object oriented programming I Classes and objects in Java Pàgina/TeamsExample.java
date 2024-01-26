public class TeamsExample{
	public static void main(String[] args){
		Team team = new Team("MERCERIA PACO", 1987);
		team.printTeam();
		System.out.println();
		Team team2 = new Team("CONOS GRATIS", 2024);
		team2.printTeam();
	}
}

public class Team{
	private String name;
	private int foundationYear;

	public String getName(){
		return name;
	}
	public int getFoundationYear(){
		return foundationYear;
	}
	public void setName(String newName){
		name = newName;
	}
	public void setFoundationYear(int newYear){
		foundationYear = newYear;
	}
	public Team(String newName, int newYear){
		name = newName;
		foundationYear = newYear;
	}

	public void printTeam(){
		System.out.println("Name of the team: "+name);
		System.out.println("Foundation year: "+foundationYear);
	}
}
