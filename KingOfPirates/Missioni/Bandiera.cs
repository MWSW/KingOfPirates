using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;

namespace KingOfPirates.Missioni
{
    /// <summary>
    /// Classe che rappresenta il punto di fine della missione
    /// </summary>
    class Bandiera
    {
        private bool missioneEnd;
        private bool giocoEnd;
        public Loc2D Coords { get; set; }

        /// <summary>
        /// Inizializza la bandiera con le coordinate grafiche.
        /// </summary>
        /// <param name="coordX">Punto X.</param>
        /// <param name="coordY">Punto Y.</param>
        public Bandiera(int coordX, int coordY)
        {
            Coords.X = coordX;
            Coords.Y = coordY;
            missioneEnd = false;
            giocoEnd = false;
        }

        public bool MissioneEnd { get => missioneEnd; set => missioneEnd = value; }
        public bool GiocoEnd { get => giocoEnd; set => giocoEnd = value; }
    }
}
