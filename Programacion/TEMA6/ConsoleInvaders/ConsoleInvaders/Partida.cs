using System;

namespace ConsoleInvaders
{
    internal class Partida
    {
        public void Lanzar()
        {
            Nave nave = new Nave(10, 10);
            Enemigo[] enemigo = new Enemigo[10];

            for (int i=0; i<10; i++)
            {
                enemigo[i] = new Enemigo(2+3*i,3,"][");
            }
            
            for(int i=0; i<10; i++) 
            {
                enemigo[i].Dibujar();
            }
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
