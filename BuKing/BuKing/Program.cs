using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BuKing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözlet! Tessen kiválasztani eme végrehajtandó feladatocskát:\n" +
                "1 - az összes eseményt mutatni fogja, és az elérhetőséget \n" +
                "2 - az elérhető eseményeket mutatni fogja\n" +
                "3 - kiírja az eseményről való adatokat\n" +
                "4 - lefoglalhat egy elérhető esemény jegyét");

            Console.WriteLine("\nKérem a sorszámot: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());

            while (sorszam != 0)
            {

                switch (sorszam)
                {
                    case 1:
                        osszeskiiras();
                        break;
                    case 2:
                        elerhetokiiras();
                        break;
                    case 3:
                        esemenyadatok();
                        break;
                    case 4:
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