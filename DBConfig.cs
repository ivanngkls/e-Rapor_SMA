using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Raport_SMA
{
    public static class DBConfig
    {
        public static string dbServer = "localhost";
        public static string dbUser = "root";
        public static string dbName = "e-raport";
        public static string dbPass = "";
        public static string connStr => $"server={dbServer};user={dbUser};database={dbName};password={dbPass};";
    }
}
