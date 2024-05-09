namespace ProyectoFinal
{
    internal class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public Usuario(string idUsuario, string nombre, string contraseña, string rol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Rol = rol;
        }
        public Usuario() { }
    }
}
