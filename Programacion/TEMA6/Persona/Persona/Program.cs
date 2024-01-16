using System;

namespace Persona
{
    class PruebaPersona
    {
        static void Main()
        {
            Persona persona = new Persona();

            persona.SetNombre("Juan");
            persona.Saludar();
        }
    }
}