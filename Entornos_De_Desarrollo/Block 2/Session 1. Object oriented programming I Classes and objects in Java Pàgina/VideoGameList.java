public class VideoGameList{
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

public class VideoGame{
	private String title;
	private String genre;
	private int price;

	public String getTitle(){
		return title;
	}
	public String getGenre(){
		return genre;
	}
	public int getPrice(){
		return price;
	}
	public void setTitle(String newTitle){
		title = newTitle;
	}
	public void setGenre(String newGenre){
		genre = newGenre;
	}
	public void getPeice(int newPrice){
		price = newPrice;
	}

	public VideoGame(String title, String genre, int price){
		this.title = title;
		this.genre = genre;
		this.price = price;
	}

	public void printVideoGame(){
		System.out.printf("Title: %s | Genre: %s | Price: %d", this.title, this.genre, this.price);
		System.out.println();
	}
}