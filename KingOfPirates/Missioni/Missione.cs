using KingOfPirates.Missioni.Navi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.GUI;

namespace KingOfPirates.Missioni
{
    public class Missione
    {
        private int Reward { get; set; }
        private string Descrizione { get; set; }
        protected GUI.MenuMissioni.FormMissione Mappa { get; set; }
        protected NaveNemico[] Nemici { get; set; }
        internal Loc2D PosNave { get; set; }
        internal Loc2D PosBandiera { get; set; }


        public Missione(Loc2D posNave, Loc2D posBandiera, int reward)
        {
            this.PosBandiera = posBandiera;
            this.PosNave = posNave;
            this.Reward = reward;
            this.Mappa = new GUI.MenuMissioni.FormMissione(this);
        }

        public void StartMissione()
        {
            Mappa.Activate();
            //TODO: Altro codice necessario all'avvio corretto della missione
        }

        public void CicloGioco()
        {
            while (true)
            {
                //cringe
            }
        }

        public void EndMissione()
        {
            //TODO: Da il reward e contrassegna la missione come completata sulla cartina
        }
    }
}
