using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuKing
{
    internal class Jegy
    {
        private string jegytipus;
        private int jegyar;
        private int esemenyid;
        private int mennyiseg;
        private int jegyid;

        public Jegy(string jegytipus, int jegyar, int esemenyid, int mennyiseg, int jegyid)
        {
            Jegytipus = jegytipus;
            Jegyar = jegyar;
            Esemenyid = esemenyid;
            Mennyiseg = mennyiseg;
            Jegyid = jegyid;
        }

        public string Jegytipus { get => jegytipus; set => jegytipus = value; }
        public int Jegyar { get => jegyar; set => jegyar = value; }
        public int Esemenyid { get => esemenyid; set => esemenyid = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public int Jegyid { get => jegyid; set => jegyid = value; }

        public override string ToString()
        {
            return $"{jegytipus}, {jegyar}, {esemenyid}, {mennyiseg}, {jegyid}";
        }
    }
}
