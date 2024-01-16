using System;

namespace Persona
{
    internal class Persona
    {
        string nombre;

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", nombre);
        }
    }
}
