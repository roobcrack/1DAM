using System;

namespace ConsoleInvaders
{
    internal class Partida
    {
        public void Lanzar()
        {
            //Console.WriteLine("Ésta sería la pantalla de juego. Pulse Intro para salir");
            Nave nave = new Nave(10, 10);
            Enemigo enemigo = new Enemigo(8, 3, "][");
            Enemigo enemigo2 = new Enemigo();

            enemigo.Dibujar();
            enemigo2.Dibujar();
            nave.Dibujar();
            ConsoleKeyInfo tecla;

            do 
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    nave.MoverIzquierda();
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    nave.MoverDerecha();
                }
            } while (tecla.Key != ConsoleKey.Escape);
            Console.Clear();
        }
    }
}
