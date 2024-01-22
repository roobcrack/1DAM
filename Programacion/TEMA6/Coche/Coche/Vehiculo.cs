using System;

namespace Coche
{
    internal class Vehiculo
    {
        protected string marca {  get; set; }
        protected string modelo { get; set; }
        protected int cilindrada { get; set; }
        protected int potencia { get; set; }
        protected int cantidadRuedas {  get; set; }
        protected int velocidad { get; set; }

        public void EstablecerVehiculo(string modelo, string marca, int cilindrada, int potencia)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
            velocidad = 50;
        }
        public void ImprimirVehiculo()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Cilindrada: " + cilindrada);
            Console.WriteLine("Potencia: " + potencia);
            Console.WriteLine("Cantidad ruedas: " + cantidadRuedas);
        }
        public void Circular()
        {
            Console.WriteLine("Circula a {0}km/h", velocidad);
        }
        public void Circular(int velocidad)
        {
            Console.WriteLine("Circula a {0}km/h", velocidad);
        }
    }
}
