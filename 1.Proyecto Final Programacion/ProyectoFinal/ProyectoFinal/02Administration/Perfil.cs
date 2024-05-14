using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Perfil
    {
        public string IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public string Resumen { get; set; }

        public Perfil(string idPerfil, string nombrePerfil, string resumen)
        {
            IdPerfil = idPerfil;
            NombrePerfil = nombrePerfil;
            Resumen = resumen;
        }
        public Perfil() { }
    }
}
