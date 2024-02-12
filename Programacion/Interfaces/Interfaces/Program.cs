using System;

class Program
{
    static void Main()
    {
        Coche[] coche = new Coche[5];

        coche[0] = new Coche("Mercedes", "Benz", 45);
        coche[1] = new Coche("Honda", "civic", 12);
        coche[2] = new Coche("Ford", "Focus", 0);
        coche[3] = new Coche("Citroen", "Picaso", 110);
        coche[4] = new Coche("Nissan", "Skyline", 0);

        for(int i=0; i<5; i++)
        {
            coche[i].Conducir();
            if (coche[i].getGasolina() == 0)
            {
            bool salir = false;
                while (!salir)
                {
                    try
                    {
                        Console.Write("Introduzca la cantidad de gasolina a repostar: ");
                        int gasolina = Convert.ToInt32(Console.ReadLine());
                        if (gasolina <= 0)
                            throw new Exception("Debe insertar un numero mayor a 0");
                        coche[i].Repostar(gasolina);
                        salir = true;
                    } catch(Exception e) { Console.WriteLine("ERROR: {0}\n", e.Message); }
                }
                i--;
            }  
            Console.WriteLine();
        }
    }
}