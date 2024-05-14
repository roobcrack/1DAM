using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Comentario
    {
        public string IdComentario { get; set; }
        public string Conntenido {  get; set; }

        public Comentario(string idComentario, string conntenido)
        {
            IdComentario = idComentario;
            Conntenido = conntenido;
        }
    }
}
