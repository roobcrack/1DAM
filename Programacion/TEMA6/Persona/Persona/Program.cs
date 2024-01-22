using System;

namespace Persona
{
    class PruebaPersona
    {
        static void Main()
        {
            Persona persona = new Persona("Juan");
            PersonaInglesa personaIn = new PersonaInglesa();
            PersonaItaliana personaIt = new PersonaItaliana("Paco");

            persona.Saludar("Hola, soy");
            personaIn.TomarTe();
            personaIn.Saludar("Hi, i am");
            personaIt.Saludar("Ciao");
        }
    }
}