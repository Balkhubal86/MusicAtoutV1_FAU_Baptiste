using MusicAtoutV1_FAU_Baptiste.Models;

namespace MusicAtoutV1_FAU_Baptiste
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
            ModelProjet.init();
            Application.Run(new FConnexion());
        }
    }
}