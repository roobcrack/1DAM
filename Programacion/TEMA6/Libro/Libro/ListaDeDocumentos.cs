using System;

namespace Libro
{
    internal class ListaDeDocumentos
    {
        public int Capacidad {  get; set; }
        public int Cantidad { get; set; }
        public Documento[] Documentos { get; set; }

        public ListaDeDocumentos()
        {
            this.Capacidad = 1000;
            this.Cantidad = 0;
            this.Documentos = new Documento[this.Capacidad];
        }

        public void Crear(Documento documento)
        {
            this.Documentos[this.Cantidad++] = documento;
        }
        public void Borrar(int posicionBorrar)
        {
            for (int i = posicionBorrar; i < this.Cantidad; i++)
                this.Documentos[i] = this.Documentos[i + 1];
            this.Cantidad--;
        }
        public string Buscar(string textoBuscar)
        {
            string cadena = string.Empty;
            for(int i=0; i<this.Cantidad; i++)
            {
                if (this.Documentos[i].Contiene(textoBuscar))
                    cadena += this.Documentos[i].ToString()+"\n";
            }
            if (cadena == string.Empty) return "No se encontraron coincidencias";
            return cadena;
        }
        public string Mostrar()
        {
            string cadena = string.Empty;
            for(int i=0; i< this.Cantidad; i++)
            {
                cadena += this.Documentos[i].ToString()+"\n";
            }
            if (cadena == string.Empty) return "No hay ningun documento";
            return cadena;
        }
    }
}
