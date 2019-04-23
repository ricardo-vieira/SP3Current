using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace SP3.Utils
{
    public static class IniSP3Config
    {
        private static IniData SP3Ini { get; set; }
        private static string ConnectionSGBD { get => SP3Ini?["CONNECTION"]["SGBD"]; }
        private static string ConnectionServer { get => SP3Ini?["CONNECTION"]["Server"]; }
        private static string ConnectionUser { get => SP3Ini?["CONNECTION"]["User"]; }
        private static string ConnectionPassword { get => SP3Ini?["CONNECTION"]["Password"]; }
        private static string ConnectionDatabase { get => SP3Ini?["CONNECTION"]["Database"]; }

        public static string ConnectionString
        {
            get
            {
                if (SP3Ini == null)
                {
                    LoadSP3IniFile();
                }

                switch (ConnectionSGBD.ToUpper())
                {
                    case "MSSQLSERVER":
                        return String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}; MultipleActiveResultSets=True",
                                             ConnectionServer,
                                             ConnectionDatabase,
                                             ConnectionUser,
                                             ConnectionPassword);
                    default:
                        return String.Empty;
                }
            }
        }

        public static string ConnectionStringEntityFramework
        {
            get
            {
                var conn = ConnectionString;

                switch (ConnectionSGBD.ToUpper())
                {
                    case "MSSQLSERVER":
                        return String.Format(@"metadata=res://*/edmProjetos.csdl|res://*/edmProjetos.ssdl|res://*/edmProjetos.msl;" +
                                      "provider=System.Data.SqlClient;" +
                                      "provider connection string=&quot;" +
                                      "{0};" +
                                      "App=EntityFramework&quot;", conn);
                    default:
                        return string.Empty;
                }
            }
        }

        public static bool CreateDefaultSP3IniFile()
        {
            var parser = new FileIniDataParser();
            IniData data = new IniData();
            data["CONNECTION"]["SGBD"] = "MSSQLServer";
            data["CONNECTION"]["Server"] = @"localhost\SQLEXPRESS";
            data["CONNECTION"]["User"] = "sa";
            data["CONNECTION"]["Password"] = "sp3corrente";
            data["CONNECTION"]["Database"] = "SP3";


            parser.WriteFile("SP3.ini", data);
            return true;
        }

        public static bool LoadSP3IniFile()
        {
            var parser = new FileIniDataParser();
            SP3Ini = parser.ReadFile("SP3.ini");
            return true;
        }
    }
}
