using AgenciaViagem.Controlls;
using AgenciaViagem.Enums;
using AgenciaViagem.Models;
using AgenciaViagem.Views;

namespace AgenciaViagem
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

            Application.Run(new fConfiguração());
        }
    }
}