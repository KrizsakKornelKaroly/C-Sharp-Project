using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuKing
{
    internal class Esemeny
    {
        public int Esemeny_id;
        public string Nev;
        public DateTime Idopont;
        public int Helyszin_id;

        public Esemeny(int esemeny_id, string nev, DateTime idopont, int helyszin_id)
        {
            Esemeny_id = esemeny_id;
            Nev = nev;
            Idopont = idopont;
            Helyszin_id = helyszin_id;
        }
    }
}
