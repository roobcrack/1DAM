using System;
using System.Xml.Serialization;

namespace ConsoleInvaders
{
    internal class Nave : Sprite
    {
        public Nave(int setX, int setY, string setImg)
        {
            x = setX;
            y = setY;
            imagen = setImg;
        }
    }
}
