using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SP3.Utils;


namespace projProjetos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region CarregarConfiguracoes

            if (!File.Exists(Application.StartupPath + @"\SP3.ini"))
            {
                IniSP3Config.CreateDefaultSP3IniFile();
            }

            IniSP3Config.LoadSP3IniFile();
            var config = ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.None);
            var connectionStringSection = (ConnectionStringsSection) config.GetSection("connectionStrings");
            connectionStringSection.ConnectionStrings["dbProjetosEntities"].ConnectionString = SP3.Utils.IniSP3Config.ConnectionStringEntityFramework;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new projProjetos.Forms.FrmPrincipal().ShowDialog();
        }
    }
}
