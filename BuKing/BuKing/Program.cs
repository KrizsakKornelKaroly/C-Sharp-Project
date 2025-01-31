using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BuKing
{
    internal class Program
    {
        public static List<Helyszin> helyszinek = new List<Helyszin>();
        public static List<Esemeny> esemenyek = new List<Esemeny>();
        static void Main(string[] args)
        {
            Fajlbeolvasas.KapcsolodasDB();

            Console.WriteLine("Üdvözlet! Tessen kiválasztani eme végrehajtandó feladatocskát:\n" +
                "1 - Az összes esemény lekérdezése helyszínnel és időponttal együtt \n" +
                "2 - Jegyelérhetőségek lekérdezése\n" +
                "3 - Jegyvásárlás\n");
            Console.WriteLine("\nKérem a sorszámot: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
           

            while (sorszam != 0)
            {

                switch (sorszam)
                {
                    case 1:
                       
                        Fajlbeolvasas.EsemenyekEsHelyszínek();
                        break;
                    case 2:
                        elerhetokiiras();
                        break;
                    case 3:
                        foglalas();
                        break;
                    default:
                        Console.Write("Ez nincs a parancsaim között");
                        break;
                }
                Console.WriteLine("\nKérem a sorszámot: ");
                sorszam = Convert.ToInt32(Console.ReadLine());
            }


        }

        private static void foglalas()
        {
            Console.Write("FOGLALÁS!!");

        }

        private static void esemenyadatok()
        {
            Console.Write("EseményADATOK!!");
        }

        private static void elerhetokiiras()
        {
            Console.Write("ELÉRHETŐKIíRÁS!!");
        }

        private static void osszeskiiras()
        {
            Console.Write("ÖSSZESKIIíRÁS");
            for (int i = 0; i < 10; i++)
            {


            }
        }
    }
}