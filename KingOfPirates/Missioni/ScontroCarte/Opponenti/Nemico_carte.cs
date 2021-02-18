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
        private Carta cartaUsata;

        public Nemico_carte(int hp_, Bitmap img_, Carta[] mazzo_)
            : base(hp_, img_)
        {
            mazzo = mazzo_;
        }

        public void ScegliCarta()
        {
            Random rng = new Random();
            cartaUsata = mazzo[rng.Next(0, mazzo.Length -1)];  //FIX-ME (non va bene il mazzo)
        }

        public Carta CartaUsata { get => cartaUsata; }
    }
}
