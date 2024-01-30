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