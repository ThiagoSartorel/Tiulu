using System.Globalization;
namespace ProjetoPastelaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string auxIdiomaRegiao = "en-US";
            
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);

            //Alterar textos

            


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}