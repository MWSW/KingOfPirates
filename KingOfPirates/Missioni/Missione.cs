using KingOfPirates.Missioni.Navi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    class Missione
    {

        private int reward;
        private string descrizione;

        Griglia mappa;

        NaveNemico[] nemici;

        public Missione(int reward_, int righe_, int colonne_)
        {
            reward = reward_;
            mappa = new Griglia(righe_, colonne_, false);
        }

        //Getter e Setters dello standard C#
        public int Reward { get => reward; set => reward = value; }
        internal Griglia Mappa { get => mappa; set => mappa = value; }
        private string Descrizione { get => descrizione; set => descrizione = value; }

    }
}
