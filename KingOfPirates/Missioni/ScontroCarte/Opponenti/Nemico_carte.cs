using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    class Nemico_carte : Giocatore_carte_base
    {
        private Carta[] mazzo;

        public Nemico_carte(int hp_, Bitmap img_, Carta[] mazzo_)
            : base(hp_, img_)
        {
            mazzo = mazzo_;
        }

        public Carta UsaCarta()
        {
            Random rng = new Random();
            return mazzo[rng.Next(0, mazzo.Length -1)];  //FIX-ME (non va bene il mazzo)
        }

    }
}
