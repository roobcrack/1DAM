using System;

namespace ConsoleInvaders
{
    internal class Sprite
    {
        protected int x;
        protected int y;
        protected string imagen = "/\\";

        public int GetX() {  return x; }
        public int GetY() { return y; }
        public void SetX(int nuevaX) { x = nuevaX; }
        public void SetY(int nuevaY) {  y = nuevaY; }
        public void Mover(int nuevaX, int nuevaY, string nuevaImagen)
        {
            Console.SetCursorPosition(x-1, y);
            Console.WriteLine("    ");
            x = nuevaX;
            y = nuevaY;
            imagen = nuevaImagen;
        }
        public void Dibujar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(imagen);
        }
    }
}
