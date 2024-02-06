public class PCVideoGame extends VideoGame{
    private int minimumRAM;
    private int minimumHD;
    public int getMinimumRam(){ return this.minimumRAM; }
    public int getMinimumHD(){ return this.minimumHD; }
    public void setMinimumRAM(int minimumRAM){ this.minimumRAM = minimumRAM; }
    public void setMinimumHD(int minimumHD){ this.minimumHD = minimumHD; }

    public PCVideoGame(String title, String genre, int price, int minimumRAM, int minimumHD){
        super(title, genre, price);
        this.minimumRAM = minimumRAM;
        this.minimumHD = minimumHD;
    }

    @Override
    public String toString(){
        return super.toString()+" | MinimumRAM: "+this.minimumRAM+"gb | MinimumHD: "+this.minimumHD;
    }
}
