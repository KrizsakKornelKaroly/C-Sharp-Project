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
            
            List<Helyszin> helyszinek= Fajlbeolvasas.Kilistazas();
            

            Console.WriteLine("Üdvözlet! Tessen kiválasztani eme végrehajtandó feladatocskát:\n" +
                "1 - Az összes esemény lekérdezése helyszínnel és időponttal együtt \n" +
                "2 - Jegyelérhetőségek lekérdezése\n" +
                "3 - Jegyvásárlás\n" +
                "0 - Kilépés");
            Console.WriteLine("\nKérem a sorszámot: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            string valasztasszoveg ="";
            string idopont = "";
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
                        "1 - Marathon, 2025-05-30 02:09:15\n" +
                        "2 - Marathon, 2025-07-21 16:32:09\n" +
                        "3 - Marathon, 2025-08-16 02:21:21\n" +
                        "4 - Rock Concert, 2025-01-04 18:43:49\n" +
                        "5 - Rock Concert, 2025-05-31 08:10:56\n" +
                        "6 - Art Exhibition, 2025-03-07 18:43:27\n" +
                        "7 - Art Exhibition, 2025-10-04 01:15:18\n" +
                        "8 - Food Festival, 2025-03-12 03:14:33\n" +
                        "9 - Tech Conference, 2025-02-23 14:41:25\n" +
                        "0 - Kilépés");
                        Console.WriteLine("\nKérem a számot: ");
                        sorszam2 = Convert.ToInt32(Console.ReadLine());
                        switch (sorszam2)
                        {
                            case 1:
                                valasztasszoveg = "Marathon";
                                idopont = "2025-05-30 02:09:15";
                                break;
                            case 2:
                                valasztasszoveg = "Marathon";
                                idopont = "2025-07-21 16:32:09";
                                break;
                            case 3:
                                valasztasszoveg = "Marathon";
                                idopont = "2025-08-16 02:21:21";
                                break;
                            case 4:
                                valasztasszoveg = "Rock Concert";
                                idopont = "2025-01-04 18:43:49";
                                break;
                            case 5:
                                valasztasszoveg = "Rock Concert";
                                idopont = "2025-05-31 08:10:56";
                                break;
                            case 6:
                                valasztasszoveg = "Art Exhibition";
                                idopont = "2025-03-07 18:43:27";
                                break;
                            case 7:
                                valasztasszoveg = "Art Exhibition";
                                idopont = "2025-10-04 01:15:18";
                                break;
                            case 8:
                                valasztasszoveg = "Food Festival";
                                idopont = "2025-03-12 03:14:33";
                                break;
                            case 9:
                                valasztasszoveg = "Tech Conference";
                                idopont = "2025-02-23 14:41:25";
                                break;

                            default:
                                break;
                        }
                        Fajlbeolvasas.Elerhetokiiras(valasztasszoveg, idopont);
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