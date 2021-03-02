using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using KingOfPirates.Missioni;

namespace KingOfPirates.Mappa
{
    /// <summary>
    /// Classe che rappresenta la cartina delle missioni
    /// </summary>
    class Cartina
    {
        Missione[] arcipelago1;
        //Missione[] arcipelago2;

        int currentMissionIndex;

        /// <summary>
        /// Inizializza le collezioni di missioni (Arcipelaghi)
        /// </summary>
        public Cartina()
        {
            arcipelago1 = new Missione[3];
            currentMissionIndex = 0;
        }

        public int CurrentMissionIndex { get => currentMissionIndex; set => currentMissionIndex = value; }

        public void AvvioMissione()
        {
            //TODO
        }
    }
}
