using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    abstract class Giocatore
    {
        private int hp;
        protected Carta[] mazzo;

        private Inventario inv;

        public Giocatore(int hp_, int nCarte)
        {
            hp = hp_;
            mazzo = new Carta[nCarte]; //istanzia nuovo mazzo
        }

        public void AssegnaCarta(Carta carta, int n)
        {

        }
    }
}
