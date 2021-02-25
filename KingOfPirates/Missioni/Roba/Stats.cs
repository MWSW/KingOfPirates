using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Roba
{
    public class Stats
    {
        private int hp;
        private int pa; //punti azione
        private int maxHit;
        private int minHit;

        public int Hp { get => hp; set => hp = value; }
        public int Pa { get => pa; set => pa = value; }
        public int MaxHit { get => maxHit; set => maxHit = value; }
        public int MinHit { get => minHit; set => minHit = value; }

        public Stats(int hp_, int pa_, int minHit_, int maxHit_)
        {
            hp = hp_;
            pa = pa_;
            minHit = minHit_;
            maxHit = maxHit_;
        }

        public Stats()
        {
            Hp = 0;
            pa = 10;
            minHit = 0;
            maxHit = 10;
        }
    }
}
