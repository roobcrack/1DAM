public class VideoGame{
    protected String title;
    protected String genre;
    protected int price;

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

    public String toString(){
        return "Title: "+this.title+" | Genre: "+this.genre+" | Price: "+this.price;
    }
}