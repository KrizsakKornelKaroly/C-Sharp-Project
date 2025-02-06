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

        public static List<Jegy> Kilistazas()
        {
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM `jegy`", connection))
            {

                using (MySqlDataReader mySqlDataReader = command.ExecuteReader())
                {
                    List<Jegy> adatok = new List<Jegy>();
                    while (mySqlDataReader.Read())
                    {

                        

                        adatok.Add(new Jegy(Convert.ToString(mySqlDataReader[0]),
                                                        Convert.ToInt32(mySqlDataReader[1]),
                                                        Convert.ToInt32(mySqlDataReader[2]),
                                                        Convert.ToInt32(mySqlDataReader[3]),
                                                        Convert.ToInt32(mySqlDataReader[4])


                                                        ));

                    }
                    return adatok;
                }
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
        public static void Elerhetokiiras(string esemenyneve, string idopont)
        {

            try
            {
                using (MySqlCommand lekerdezesEsHe = new MySqlCommand($"SELECT jegy.jegytipus, jegy.jegyar ,jegy.mennyiseg FROM `esemeny` INNER JOIN jegy on esemeny.esemeny_id = jegy.esemeny_id WHERE esemeny.nev = '{esemenyneve}' AND esemeny.idopont = '{idopont}' ORDER by esemeny.idopont;; ", connection))

                {
                    using (MySqlDataReader mySqlDataReader = lekerdezesEsHe.ExecuteReader())
                    {

                        while (mySqlDataReader.Read())
                        {
                            Console.WriteLine($"Jegytípus:{mySqlDataReader[0]},\n Jegyár: {mySqlDataReader[1]},\n Mennyiség: {mySqlDataReader[2]}" +
                                $"\n--------------------------------------------------------------------");

                        }
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Porszem csúszott a gépezetbe!");
            }
        }
        public static void Jegyfoglalas(int ID, int mennyiseg)
        {

            try
            {
                using (MySqlCommand lekerdezesEsHe = new MySqlCommand($"UPDATE `jegy` SET `mennyiseg`= @mennyiseg WHERE jegy.jegy_id ={ID};  ", connection))

                {
                    lekerdezesEsHe.Parameters.AddWithValue("@mennyiseg", mennyiseg - 1);
                    int rowsAffected = lekerdezesEsHe.ExecuteNonQuery();
                    Console.WriteLine("\nSikeres fizetés \n" +
                        "----------------------------");

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Porszem csúszott a gépezetbe!");
            }
        }

        public static int Jegyazonositas(string esemenyneve, string idopont, int hanyadik)
        {
            int szamlalo = 1;
            int ertek = 0;
            try
            {
                using (MySqlCommand lekerdezesEsHe = new MySqlCommand($"SELECT jegy.jegy_id FROM `esemeny` INNER JOIN jegy on esemeny.esemeny_id = jegy.esemeny_id WHERE esemeny.nev = '{esemenyneve}' AND esemeny.idopont = '{idopont}' ORDER by esemeny.idopont; ;; ", connection))

                {
                    using (MySqlDataReader mySqlDataReader = lekerdezesEsHe.ExecuteReader())
                    {

                        while (mySqlDataReader.Read())
                        {
                            
                            if (hanyadik == szamlalo) {
                                ertek = Convert.ToInt32(mySqlDataReader[0]);
                            }
                            szamlalo++;

                        }
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Porszem csúszott a gépezetbe!");
            }
            if (hanyadik <= 0)
            {
                Console.WriteLine("\nNincsen ilyen jegy\n");
            }
            else if (ertek == 0)
            {
                Console.WriteLine("\nNincsen ilyen jegy\n");

            }
            
            return ertek;
        }

    }
}
