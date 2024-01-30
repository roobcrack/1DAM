public class Team {
    private String name;
    private int foundationYear;

    public String getName(){ return name; }
    public int getFoundationYear(){ return foundationYear; }
    public void setName(String newName){ name = newName; }
    public void setFoundationYear(int newYear){ foundationYear = newYear; }
    public Team(String newName, int newYear){
        name = newName;
        foundationYear = newYear;
    }
    Player player1 = new Player("Jaime", 18, 3);
    Player player2 = new Player("Jose", 22, 4);
    Player player3 = new Player("Julian", 23, 11);
    Player player4 = new Player("Pedro", 19, 1);
    Player player5 = new Player("Eric", 19, 10);

    public void printTeam(){
        System.out.println("Name of the team: "+name);
        System.out.println("Foundation year: "+foundationYear);
        System.out.println("Members: ");
        player1.PrintPlayers();
        player2.PrintPlayers();
        player3.PrintPlayers();
        player4.PrintPlayers();
        player5.PrintPlayers();
    }
}
