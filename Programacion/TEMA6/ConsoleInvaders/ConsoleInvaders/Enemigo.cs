using System;

namespace ConsoleInvaders
{
    internal class Enemigo : Sprite
    {
        public Enemigo(int x, int y, string imagen)
        {
            this.x = x;
            this.y = y;
            this.imagen = imagen;
        }
        public Enemigo()
        {
            this.x = 4;
            this.y = 8;
            this.imagen = ")(";
        }
    }
}