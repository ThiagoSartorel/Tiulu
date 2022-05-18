using System.Configuration;
using System.Data;
using System.Data.Common;
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
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao"):"";                  
            
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(auxIdiomaRegiao!);

            //Alterar textos

            


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
} 