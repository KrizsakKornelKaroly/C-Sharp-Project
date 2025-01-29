using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BuKing
{
    internal class Fajlbeolvasas
    {

        private static string server = "localhost";
        private static string database = "";
        private static string user = "root";
        private static string password = "";
        private static List<Booking> orszagokList = new List<Booking>();

        private static string connectionString = $"Server={server};Database={database};User ID={user};Password={password};";
        public static MySqlConnection connection = new MySqlConnection(connectionString);






    }
}
