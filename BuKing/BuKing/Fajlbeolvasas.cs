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
        private static string connectionString = $"Server=localhost;Database=12a_buking;User ID=root;Password=;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        public static void KapcsolodasDB()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Minden baba.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valami nem jó: " + ex.Message);
            }
        }

        public static void EsemenyekEsHelyszínek()
        {

        }


        private static List<Booking> bookingList = new List<Booking>();



    }
}
