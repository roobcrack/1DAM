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

            frmLogin frmLogin = new frmLogin();
            Application.Run(frmLogin);
            usuarioActual = frmLogin.Usuario;
            frmLogin.Close();
            if (usuarioActual is not null)
                Application.Run(new frmUsuarios(usuarioActual));
        }
    }
}
