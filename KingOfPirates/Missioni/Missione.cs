﻿using KingOfPirates.Missioni.Navi;
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
        internal GUI.MenuMissioni.FormMissione Mappa { get; set; }
        protected NaveNemico[] Nemici { get; set; }
        internal Loc2D PosNave { get; set; }
        internal Loc2D PosBandiera { get; set; }
        internal Griglia Griglia_numerica { get; set; }


        public Missione(Griglia Griglia_numerica, Loc2D posNave, Loc2D posBandiera, int reward)
        {
            this.PosBandiera = posBandiera;
            this.PosNave = posNave;
            this.Reward = reward;

            this.Griglia_numerica = Griglia_numerica;
            this.Mappa = new GUI.MenuMissioni.FormMissione(this);
        }

        public void StartMissione()
        {
            Gioco.Giocatore.Missione = this;
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
