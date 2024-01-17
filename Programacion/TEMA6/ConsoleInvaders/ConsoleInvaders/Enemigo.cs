using System;
using System.Xml.Serialization;

namespace ConsoleInvaders
{
    internal class Enemigo : Sprite
    {
        public Enemigo(int setX, int setY, string setImg)
        {
            x = setX;
            y = setY;
            imagen = setImg;
        }
    }
}