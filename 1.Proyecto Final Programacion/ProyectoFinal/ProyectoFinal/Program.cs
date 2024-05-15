using ProyectoFinal._01View;
using ProyectoFinal._02Administration;
using ProyectoFinal._03Data;

namespace ProyectoFinal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Usuario usuarioActual = null;

            //CREA EL LOGIN Y LO EJECUTA
            frmLogin frmLogin = new frmLogin();
            Application.Run(frmLogin);
            usuarioActual = frmLogin.Usuario;

            //COMPROBAR SI NO SE HA INICIADO UN USUARIOACTUAL REAL
            if (usuarioActual is not null && 
                string.IsNullOrWhiteSpace(usuarioActual.Nombre))   
            {
                frmRegistro frmRegistro = new frmRegistro();
                Application.Run(frmRegistro);
                usuarioActual = frmRegistro.Usuario;
            }
            //SI HAY UN USUARIOACTUAL INICIADO SE ABRE EL FORMULARIO DE USUARIO
            if (usuarioActual is not null &&
                !string.IsNullOrWhiteSpace(usuarioActual.Nombre))
                Application.Run(new frmUsuarios(usuarioActual));
        }
    }
}
 