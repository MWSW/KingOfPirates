using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Roba
{
    public class Stats
    {
        public int Hp { get; set; } // Punti Vita (Health Points)
        public int HpMax { get; set; }
        public int Pa { get; set; } // Punti Azione
        public int PaMax { get; set; }
        public int MaxHit { get; set; } // Danno minimo
        public int MinHit { get; set; } // Danno massimo

        public Stats(int hp,int hpMax , int pa, int paMax, int minHit, int maxHit)
        {
            Hp = hp;
            HpMax = hpMax;
            Pa = pa;
            PaMax = paMax;
            MinHit = minHit;
            MaxHit = maxHit;
        }
    }
}
