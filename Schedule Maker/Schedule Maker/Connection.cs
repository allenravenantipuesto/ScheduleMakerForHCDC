using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Maker
{
    class Connection
    {
        static string port = "3306";

        static string serverName = "localhost";
        static string user = "root";
        static string password = "";

        static string database = "schedulemaker";

        static string connectionString = String.Format("server={0};port={1};uid={2};password={3};database={4}",
                    serverName, port, user, password, database);

        

        static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlConnection Conn
        {
            get { return conn; }
        }
        static string sessionUserID = "";
        public static string SessionUserID
        {
            get { return sessionUserID; }
            set { sessionUserID = value; }
        }
    }
}
