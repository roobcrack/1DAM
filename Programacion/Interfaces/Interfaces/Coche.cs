using System;

interface IVehiculo
{
    void Conducir();
    void Repostar(int gasolina);
}

class Coche : IVehiculo
{
    private string marca { get; set; }
    private string modelo { get; set; }
    private int gasolina { get; set; }
    public int getGasolina() { return this.gasolina; }

    public Coche(string marca, string modelo, int gasolina)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.gasolina = gasolina;
    }

    public void Conducir()
    {
        if(this.gasolina > 0)
            Console.WriteLine("Conduciendo");
        else
            Console.WriteLine("No hay gasolina");
        Console.WriteLine(ToString());
    }

    public void Repostar(int gasolina)
    {
        this.gasolina += gasolina;
    }

    public string ToString()
    {
        return " | Marca: " + this.marca + " | Modelo: " + 
            this.modelo + " | Gasolina: " + this.gasolina + " |";
    }
}
