using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                Console.WriteLine("Sikeres kapcsolódás az adatbázishoz! \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valami nem jó: " + ex.Message + "\n");
            }
        }

        public static void EsemenyekEsHelyszínek(ref List<string> EsemenyekHelyEsIdopont)
        {
            
            try
            {
                using (MySqlCommand lekerdezesEsHe = new MySqlCommand("SELECT nev, idopont, megnev, cim FROM `esemeny` INNER JOIN helyszin ON esemeny.helyszin_id = helyszin.helyszin_id", connection))
                {
                    using (MySqlDataReader mySqlDataReader = lekerdezesEsHe.ExecuteReader())
                    {
                        while (mySqlDataReader.Read())
                        {
                            EsemenyekHelyEsIdopont.Add($"Esemény: {mySqlDataReader[0]},\n Időpont: {mySqlDataReader[1]},\n Cím: {mySqlDataReader[3]},\n Létesítmény: {mySqlDataReader[2]}\n");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Porszem csúszott a gépezetbe!");
            }
        }

        public static void Adatkiiratas(List<string> bemenet)
        {
            for (int i = 0; i < bemenet.Count; i++)
            {
                Console.WriteLine(bemenet[i]);
            }
        }

    }
}
