using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates
{
    class Ranking
    {
        private int rankGiocatore;
        private int[] livelli; //TODO

        public Ranking(int[] livelli)
        {
            this.livelli = livelli;
            rankGiocatore = 0; //TODO
        }

        public void IncRank(int size)
        {
            //TODO
        }

        public void DecRank(int size)
        {
            //TODO
        }

        public int RankGiocatore { get => rankGiocatore; set => rankGiocatore = value; }
        public int[] Livelli { get => livelli; set => livelli = value; }
    }
}
