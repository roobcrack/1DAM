namespace ProyectoFinal
{
    internal class Perfil
    {
        public string IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public string Resumen { get; set; }
        public string IdUsuario { get; set; }

        public Perfil(string idPerfil, string nombrePerfil, string resumen, string idUsuario)
        {
            IdPerfil = idPerfil;
            NombrePerfil = nombrePerfil;
            Resumen = resumen;
            IdUsuario = idUsuario;
        }
        public Perfil() { }
    }
}
