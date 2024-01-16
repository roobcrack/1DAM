using System;

namespace ConsoleInvaders
{
    class Juego
    {
        public void Lanzar()
        {
            Bienvenida bienvenida = new Bienvenida();
            do
            {
                bienvenida.Lanzar();

                if (!bienvenida.GetSalir())
                {
                    Partida partida = new Partida();
                    partida.Lanzar();
                }
            } while (!bienvenida.GetSalir());
        }
        static void Main()
        {
            Juego juego = new Juego();

            juego.Lanzar();
        }
    }
}