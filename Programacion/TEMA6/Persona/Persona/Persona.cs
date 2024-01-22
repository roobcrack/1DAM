using System;

namespace Persona
{
    internal class Persona
    {
        protected string nombre { get; set; }
        public Persona(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
        protected Persona()
        {
            this.nombre = "";
        }

        public void Saludar(string texto)
        {
            Console.WriteLine("{0} {1}", texto, nombre);
        }
    }
}
