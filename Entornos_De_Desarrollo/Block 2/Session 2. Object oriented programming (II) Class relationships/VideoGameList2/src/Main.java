public class Main{
    public static void main(String[] args){
        VideoGame[] vg = new VideoGame[5];

        vg[0] = new VideoGame("Wolfenstein ", "FPS", 10);
        vg[1] = new VideoGame("Fallout", "FPS", 10);
        vg[2] = new VideoGame("Dishonored 2", "Stealth game", 30);
        vg[3] = new VideoGame("Trove", "MMO RPG", 0);
        vg[4] = new VideoGame("World of Warcraft", "MMO RPG", 25);

        for(int i=0; i<5; i++){
            vg[i].printVideoGame();
        }
    }
}