using System;

namespace ConsoleInvaders
{
    internal class Bienvenida
    {
        bool salir = false;

        public bool GetSalir() { return salir; }
        public void Lanzar()
        {
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para jugar o ESC para salir");
            ConsoleKeyInfo tecla = Console.ReadKey();
            Console.Clear();

            if (tecla.Key == ConsoleKey.Escape) { salir = true; }
        }
    }
}
