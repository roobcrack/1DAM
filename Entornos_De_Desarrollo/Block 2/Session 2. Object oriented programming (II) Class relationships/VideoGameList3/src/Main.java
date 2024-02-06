public class Main{
    public static void main(String[] args){
        VideoGame[] vg = new VideoGame[5];

        vg[0] = new VideoGame("Wolfenstein ", "FPS", 10);
        vg[1] = new VideoGame("Fallout", "FPS", 10);
        vg[2] = new PCVideoGame("Dishonored 2", "Stealth game", 30,8,75);
        vg[3] = new VideoGame("Trove", "MMO RPG", 0);
        vg[4] = new PCVideoGame("World of Warcraft", "MMO RPG", 25, 6, 80);

        for(int i=0; i<5; i++){
            System.out.println(vg[i]);
        }
    }
}