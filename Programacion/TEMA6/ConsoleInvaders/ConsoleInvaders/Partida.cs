using System;

namespace ConsoleInvaders
{
    internal class Partida
    {
        public void Lanzar()
        {
            //Console.WriteLine("Ésta sería la pantalla de juego. Pulse Intro para salir");
            Nave nave = new Nave();
            Enemigo enemigo = new Enemigo();


            nave.SetX(10);
            nave.SetY(10);
            nave.Dibujar(nave.GetX(), nave.GetY());

            ConsoleKeyInfo tecla;

            do 
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    nave.SetX(nave.GetX() - 1);
                    nave.Mover(nave.GetX(), nave.GetY(), "/\\");
                    nave.Dibujar(nave.GetX(), nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    nave.SetX(nave.GetX() + 1);
                    nave.Mover(nave.GetX(), nave.GetY(), "/\\");
                    nave.Dibujar(nave.GetX(), nave.GetY());
                }
            } while (tecla.Key != ConsoleKey.Escape);
            Console.Clear();
        }
    }
}
