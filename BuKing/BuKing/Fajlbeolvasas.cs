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
        private static string database = "12a_buking";
        private static string user = "root";
        private static string password = "";
        private static string connectionString = $"Server={server};Database={database};User ID={user};Password={password};";
        public static MySqlConnection connection = new MySqlConnection(connectionString);


        private static List<Booking> bookingList = new List<Booking>();



    }
}
