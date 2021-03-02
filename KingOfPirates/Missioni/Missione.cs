using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        /// <value>
        /// Soldi che vengono dati al giocatore come premio.
        /// </value>
        private int Reward { get; set; }
        /// <value>
        /// Descrizione della missione, viene visualizzata nella scelta missione.
        /// </value>
        private string Descrizione { get; set; }
        /// <value>
        /// Griglia della missione.
        /// </value>
        internal FormMissione Mappa { get; set; }
        /// <summary>
        /// Form che fa vedere all'utente la sua performance
        /// </summary>
        internal FineMissione Fine { get; set; }
        /// <value>
        /// Array dei nemici presenti nella missione.
        /// </value>
        internal NaveNemico[] Nemici { get; set; }
        /// <value>
        /// Griglia numerica per settare le celle della missione.
        /// </value>
        internal Griglia Griglia_numerica { get; set; }
        /// <value>
        /// Ranking della missione.
        /// </value>
        internal Ranking Ranking { get; set; }

        /// <summary>
        /// Costruttore che prende tutti i parametri.
        /// </summary>
        /// <param name="Griglia_numerica">Griglia su cui verra basata la griglia grafica</param>
        /// <param name="reward">Premio per il raggiungimento della bandiera</param>
        /// <param name="nemici">Vettore contenente i nemici e le loro info</param>
        public Missione(Griglia Griglia_numerica, int reward, NaveNemico[] nemici)
        {
            this.Reward = reward;
            this.Nemici = nemici;

            this.Griglia_numerica = Griglia_numerica;
            this.Mappa = new FormMissione(this);

            this.Ranking = new Ranking();
            this.Fine = new FineMissione(this);
        }

        /// <summary>
        /// Muove i nemici
        /// </summary>
        public void TurnoNemico()
        {
            for (int i = 0; i < Nemici.Length; i++)
            {
                //Nemici[i].Attacca(this, Gioco.Giocatore);
                Nemici[i].Movimento(this, Direzione.NO);
            }
        }

        /// <summary>
        /// Inizializzatore missione.
        /// Mostra form, inizializza i nemici, posiziona il giocatore
        /// </summary>
        public void StartMissione()
        {
            Mappa.Show();
            //TODO: Altro codice necessario all'avvio corretto della missione
        }

        /// <summary>
        /// Terminatore missione.
        /// Esegue il dispose dei Form e libera le risorse
        /// </summary>
        public void EndMissione()
        {
            //TODO: Da il reward e contrassegna la missione come completata sulla cartina
            Fine.Dispose();
            Mappa.Dispose();
        }
    }
}
