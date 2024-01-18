using System;

namespace ConsoleInvaders
{
    internal class Sprite
    {
        protected int x { get; set; }
        protected int y { get; set; }
        protected string imagen { get; set; }

        public void Dibujar()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.WriteLine(this.imagen);
        }
    
        public void MoverA(int nuevaX, int nuevaY)
        {
            if(nuevaX>=0 && nuevaX<=79-this.imagen.Length && nuevaY>=0 && nuevaY <= 23)
            {
                this.Borrar();
                this.x = nuevaX;
                this.y = nuevaY;
                this.Dibujar();
            }
        }
        private void Borrar()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(new string(' ', this.imagen.Length));
        }
    }
}
