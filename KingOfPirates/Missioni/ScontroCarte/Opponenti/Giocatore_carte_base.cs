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
        private int hp;
        protected Mazzo mazzo;

        private Bitmap img;


        public Giocatore_carte_base(int hp_, Bitmap img_, Mazzo mazzo_)
        {
            hp = hp_;
            img = img_;
            mazzo = mazzo_;
        }

        public void AssegnaCarta(Carta carta, int n)
        {

        }
    }
}
