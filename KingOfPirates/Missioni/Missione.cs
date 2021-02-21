using KingOfPirates.Missioni.Navi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.GUI;

namespace KingOfPirates.Missioni
{
    class Missione
    {
        private int reward;
        private string descrizione;

        Bandiera bandiera { get; set; }

        GUI.MenuMissioni.FormMissione mappa;

        NaveNemico[] nemici;

        public Missione(int reward_)
        {
            bandiera = new Bandiera(5, 5);
            reward = reward_;
        }

        public void StartMissione()
        {
            mappa.Activate();
            //TODO: Altro codice necessario all'avvio corretto della missione
        }

        public void CicloGioco()
        {
            while (Gioco.Giocatore.Loc != bandiera.Coords)
            {
                //
            }
        }

        public void EndMissione()
        {
            //TODO: Da il reward e contrassegna la missione come completata sulla cartina
        }

        //Getter e Setters dello standard C#

        public int Reward { get => reward; set => reward = value; }
        private string Descrizione { get => descrizione; set => descrizione = value; }

    }
}
