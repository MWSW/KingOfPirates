using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missione.Roba
{
    class Stats
    {
        private int hp;
        private int pa; //punti azione
        private int maxHit;
        private int minHit;

        public Stats(int hp_, int pa_, int minHit_, int maxHit_)
        {
            hp = hp_;
            pa = pa_;
            minHit = minHit_;
            maxHit = maxHit_;
        }

        public Stats()
        {
            hp = 0;
            pa = 0;
            minHit = 0;
            maxHit = 0;
        }

        public int GetHp() { return hp; }
        public int GetPa() { return pa; }
        public int GetMinHit() { return minHit; }
        public int GetMaxHit() { return maxHit; }


        public void SetHp(int hp_) { hp = hp_; }
        public void SetPa(int pa_) { pa = pa_; }
        public void SetMinHit(int minHit_) { minHit = minHit_; }
        public void SetMaxHit(int maxHit_) { maxHit = maxHit_; }
    }
}
