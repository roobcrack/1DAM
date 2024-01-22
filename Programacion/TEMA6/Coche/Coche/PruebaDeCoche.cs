using System;

namespace Coche
{
    internal class PruebaDeCoche
    {
        static void Main()
        {
            Coche coche = new Coche();
            Moto moto = new Moto();

            coche.EstablecerVehiculo("Mercedes", "Benz", 22, 150);
            coche.ImprimirVehiculo();
            coche.Circular();
            Console.WriteLine();
            moto.EstablecerVehiculo("Kawasaki", "R20", 40, 220);
            moto.ImprimirVehiculo();
            moto.Circular(85);
        }
    }
}
