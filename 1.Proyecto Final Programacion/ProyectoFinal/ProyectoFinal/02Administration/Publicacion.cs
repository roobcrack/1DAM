using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Publicacion
    {
        public string IdPublicacion { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenRuta { get; set; }

        public Publicacion(string idPublicacion, string titulo, string descripcion, string imagenRuta)
        {
            IdPublicacion = idPublicacion;
            Titulo = titulo;
            Descripcion = descripcion;
            ImagenRuta = imagenRuta;
        }
    }
}
