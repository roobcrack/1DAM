namespace ProyectoFinal
{
    internal class Publicacion
    {
        public string IdPublicacion { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string ImagenRuta { get; set; }
        public string IdPerfil {  get; set; }

        public Publicacion(string idPublicacion, string titulo, string descripcion, string imagenRuta, string idPerfil)
        {
            IdPublicacion = idPublicacion;
            Titulo = titulo;
            Descripcion = descripcion;
            ImagenRuta = imagenRuta;
            IdPerfil = idPerfil;
        }
        public Publicacion() { }
    }
}
