using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Comentario
    {
        public string IdComentario { get; set; }
        public string Contenido {  get; set; }
        public string IdPublicacion { get; set; }

        public Comentario(string idComentario, string contenido, string idPublicacion)
        {
            IdComentario = idComentario;
            Contenido = contenido;
            IdPublicacion = idPublicacion;
        }
    }
}
