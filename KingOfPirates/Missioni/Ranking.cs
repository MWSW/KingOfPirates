using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    /// <summary>
    /// Contatore della performance del giocatore
    /// </summary>
    public class Ranking
    {
        public int Turni { get; set; }
        public int GameOver { get; set; }
        public int Rubini { get; set; }
        public int NaviAffondate { get; set; }

        /// <summary>
        /// Inizializza tutto a zero
        /// </summary>
        public Ranking()
        {
            Turni = 0;
            GameOver = 0;
            Rubini = 0;
            NaviAffondate = 0;
        }

        /// <summary>
        /// Incrementa turni fatti
        /// </summary>
        public void IncTurni()
        {
            Turni++;
        }

        /// <summary>
        /// Incrementa morti
        /// </summary>
        public void IncGameOver()
        {
            GameOver++;
        }

        /// <summary>
        /// Incrementa rubini trovato
        /// </summary>
        public void IncRubini()
        {
            Rubini++;
        }

        /// <summary>
        /// Incrementa navi sconfitte
        /// </summary>
        public void IncNaviAffondate()
        {
            NaviAffondate++;
        }
    }
}
