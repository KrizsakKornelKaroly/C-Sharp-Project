using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuKing
{
    internal class Helyszin
    {
        private int helyszinid;
        private int kapacitas;
        private string megnev;
        private string cim;

        public Helyszin(int helyszinid, int kapacitas, string megnev, string cim)
        {
            Helyszinid = helyszinid;
            Kapacitas = kapacitas;
            Megnev = megnev;
            Cim = cim;
        }

        public int Helyszinid { get => helyszinid; set => helyszinid = value; }
        public int Kapacitas { get => kapacitas; set => kapacitas = value; }
        public string Megnev { get => megnev; set => megnev = value; }
        public string Cim { get => cim; set => cim = value; }

        public override string ToString()
        {
            return $"{helyszinid}, {megnev}, {cim}, {kapacitas}";
        }
    }
}
