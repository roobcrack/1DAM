using System;

namespace Coche
{
    internal class Coche
    {
        string marca;
        string modelo;
        int cilindrada;
        float potencia;

        public void SetMarca(string nuevaMarca)
        {
            marca = nuevaMarca;
        }
        public void SetModelo(string nuevoModelo)
        {
            modelo = nuevoModelo;
        }
        public void SetCilindrada(int nuevaCilindrada)
        {
            cilindrada = nuevaCilindrada;
        }
        public void SetPotencia(float nuevaPotencia)
        {
            potencia = nuevaPotencia;
        }
        public string GetMarca()
        {
            return marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public int GetCilindrada()
        {
            return cilindrada;
        }
        public float GetPotencia()
        {
            return potencia;
        }
        public void PedirCoche()
        {
            Console.Write("Marca: ");
            marca = Console.ReadLine();
            Console.Write("Modelo: ");
            modelo = Console.ReadLine();
            Console.Write("Cilindrada: ");
            cilindrada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Potencia: ");
            potencia = Console.ReadLine();
        }
        public void ImprimirCoche()
        {
            Console.WriteLine("Modelo: "+modelo);
            Console.WriteLine("Marca: "+marca);
            Console.WriteLine("Cilindrada: "+cilindrada);
            Console.WriteLine("Potencia: "+potencia);
        }
    }
}
