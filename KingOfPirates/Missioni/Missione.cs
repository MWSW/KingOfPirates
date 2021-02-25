using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Navi;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.GUI.MenuMissioni;

namespace KingOfPirates.Missioni
{
    /// <summary>
    /// Classe rappresentante una missione nel gioco
    /// </summary>
    public class Missione
    {
        /// <value> Soldi che vengono dati al giocatore come premio </value>
        private int Reward { get; set; }
        /// <value> Descrizione della missione, viene visualizzata nella scelta missione </value>
        private string Descrizione { get; set; }
        /// <value>
        /// Griglia della missione
        /// </value>
        internal FormMissione Mappa { get; set; }
        /// <value>
        /// Array dei nemici presenti nella missione
        /// </value>
        protected NaveNemico[] Nemici { get; set; }
        /// <value>
        /// Posizione iniziale nave
        /// </value>
        internal Loc2D PosNave { get; set; }
        /// <value>
        /// Posizione bandiera
        /// </value>
        internal Loc2D PosBandiera { get; set; }
        /// <value> Griglia su cui viene generata la mappa grafica </value>
        internal Griglia Griglia_numerica { get; set; }

        /// <summary>
        /// Costruttore che prende tutti i parametri
        /// </summary>
        /// <param name="Griglia_numerica"></param>
        /// <param name="posNave"></param>
        /// <param name="posBandiera"></param>
        /// <param name="reward"></param>

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
            Mappa.Show();
            //TODO: Altro codice necessario all'avvio corretto della missione
        }

        public void EndMissione()
        {
            Mappa.Dispose();
            //TODO: Da il reward e contrassegna la missione come completata sulla cartina
        }
    }
}
