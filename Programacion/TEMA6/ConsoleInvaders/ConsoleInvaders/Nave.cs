using System;

namespace ConsoleInvaders
{
    internal class Nave : Sprite
    {
        public Nave(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.imagen = "/\\";
        }
        public void MoverIzquierda()
        {
            MoverA(this.x - 1, this.y);
        }
        public void MoverDerecha()
        {

            MoverA(x + 1, y);
        }
    }
}
