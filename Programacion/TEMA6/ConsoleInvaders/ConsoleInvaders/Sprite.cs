using System;

namespace ConsoleInvaders
{
    internal class Sprite
    {
        protected int x;
        protected int y;
        protected string imagen;

        public int GetX() {  return x; }
        public int GetY() { return y; }
        public string GetImagen() {  return imagen; }
        public void SetX(int x) { this.x = x; }
        public void SetY(int y) {  this.y = y; }
        public void SetImagen(string imagen) { this.imagen = imagen; } 
        public void Mover(int x)
        {
            Console.SetCursorPosition(x, this.y);
            string espacios = new string(' ', this.imagen.Length);
            Console.WriteLine(espacios);
            Dibujar();
        }
        public void Dibujar()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.imagen);
        }
        public void MoverDerecha()
        {
            if (comprobarLimite(79))
            {
                this.x++;
                Mover(this.x - 1);
            }
        }
        public void MoverIzquierda()
        {
            if (comprobarLimite(0))
            {
                this.x--;
                Mover(this.x + 1);
            }
        }
        public bool comprobarLimite(int posicion)
        {
            if (this.x == posicion)
                return false;
            return true;
        }
    }
}
