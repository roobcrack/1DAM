public class Player {
    private String name;
    private int age;
    private int number;

    public String getName(){ return name; }
    public int getAge(){ return age; }
    public int getNumber(){ return number; }
    public void setName(String name){ this.name = name; }
    public void setAge(int age){ this.age = age; }
    public void setNumber(int number){ this.number = number; }

    public Player(String name, int age, int number){
        this.name = name;
        this.age = age;
        this.number = number;
    }

    public void PrintPlayers(){
        System.out.print("Name: "+this.name+", Age: "+this.age+", Number: "+this.number);
        System.out.println();
    }
}
