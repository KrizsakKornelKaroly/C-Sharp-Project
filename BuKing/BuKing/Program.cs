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
        public static List<string> EsemenyekHelyIdopont = new List<string>();
        static void Main(string[] args)
        {
            Fajlbeolvasas.KapcsolodasDB();

            Console.WriteLine("Üdvözlet! Tessen kiválasztani eme végrehajtandó feladatocskát:\n" +
                "1 - Az összes esemény lekérdezése helyszínnel és időponttal együtt \n" +
                "2 - Jegyelérhetőségek lekérdezése\n" +
                "3 - Jegyvásárlás\n" +
                "0 - Kilépés");
            Console.WriteLine("\nKérem a sorszámot: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            string valasztasszoveg ="";
            int sorszam2;

            while (sorszam != 0)
            {

                switch (sorszam)
                {
                    case 1:
                        Fajlbeolvasas.EsemenyekEsHelyszínek(ref EsemenyekHelyIdopont);
                        Fajlbeolvasas.Adatkiiratas(EsemenyekHelyIdopont);
                        break;
                    case 2:
                        Console.WriteLine("Kérem válasszon egy számot, ami az esemény nevét jelöli:\n" +
                        "1 - Marathon\n" +
                        "2 - Rock Concert\n" +
                        "3 - Art Exhibition\n" +
                        "4 - Food Festival\n" +
                        "5 - Tech Conference \n" +
                        "0 - Kilépés");
                        Console.WriteLine("\nKérem a számot: ");
                        sorszam2 = Convert.ToInt32(Console.ReadLine());
                        switch (sorszam2)
                        {
                            case 1:
                                valasztasszoveg = "Marathon";
                                break;
                            case 2:
                                valasztasszoveg = "Rock Concert";
                                break;
                            case 3:
                                valasztasszoveg = "Art Exhibition";
                                break;
                            case 4:
                                valasztasszoveg = "Food Festival";
                                break;
                            case 5:
                                valasztasszoveg = "Tech Conference";
                                break;
                                
                            default:
                                break;
                        }
                        Fajlbeolvasas.Elerhetokiiras(valasztasszoveg);
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

        

        private static void osszeskiiras()
        {
            Console.Write("ÖSSZESKIIíRÁS");
            for (int i = 0; i < 10; i++)
            {


            }
        }
    }
}