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
            Console.WriteLine("Jó napot,itt vannak az adott parancsok \n" +
                "Osszes- az összes eseményt mutatni fogja, és az elérhetőséget \n" +
                "Elerhető- az elérhető eseményeket mutatni fogja\n" +
                "'Eseményneve'- kiírja az eseményről való adatokat\n" +
                "Bookingeseménynévadottjegy- lefoglalhat egy elérhető esemény jegyét");
        }
    }
}
