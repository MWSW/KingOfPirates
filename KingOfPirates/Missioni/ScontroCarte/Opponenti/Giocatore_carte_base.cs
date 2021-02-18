using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    abstract class Giocatore_carte_base
    {
        private int maxHp;
        private int curHp;

        private Bitmap img;


        public Giocatore_carte_base(int maxHp_, Bitmap img_)
        {
            maxHp = maxHp_;
            curHp = maxHp;

            img = img_;
        }



        public void AddHp(int val)
        {
            curHp += val;
            if (curHp >= maxHp)
                curHp = maxHp;
        }

        public void LessHp(int val)
        {
            curHp -= val;
            if (curHp < 0)
                curHp = 0;
        }

        public int CurHp {get => curHp;}
        public int MaxHp { get => maxHp; }
    }
}
