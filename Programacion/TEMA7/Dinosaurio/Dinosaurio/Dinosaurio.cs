using System;

namespace Dinosaurio
{
    internal class Dinosaurio
    {
        private string nombre { get; set; }
        private int peso { get; set; }
        private float longitud {  get; set; }

        public Dinosaurio(string nombre, int peso, float longitud)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.longitud = longitud;
        }

        public string ToString()
        {
            return this.nombre + "-" + this.peso + "-" + this.longitud;
        }
    }
}
