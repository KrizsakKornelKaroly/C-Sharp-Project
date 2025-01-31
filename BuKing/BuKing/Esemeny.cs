using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuKing
{
    internal class Esemeny
    {
        private int esemeny_id;
        private string nev;
        private DateTime idopont;
        private int helyszin_id;

        public Esemeny(int esemeny_id, string nev, DateTime idopont, int helyszin_id)
        {
            Esemeny_id = esemeny_id;
            Nev = nev;
            Idopont = idopont;
            Helyszin_id = helyszin_id;
        }

        public int Esemeny_id { get => esemeny_id; set => esemeny_id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Idopont { get => idopont; set => idopont = value; }
        public int Helyszin_id { get => helyszin_id; set => helyszin_id = value; }

        public override string ToString()
        {
            return $"{esemeny_id}, {nev}, {idopont}, {helyszin_id}";
        }
    }
}
