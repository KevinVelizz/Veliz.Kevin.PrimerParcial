namespace Aplicacion01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmAerolinea());
            //Application.Run(new IngresarUsuario());
            //Application.Run(new FrmIniciarSesion());
        }
    }
}