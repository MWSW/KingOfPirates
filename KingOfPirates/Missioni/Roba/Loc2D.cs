using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Roba
{
    /// <summary>
    /// Classe che rappresenta delle coordinate in una griglia
    /// </summary>
    public class Loc2D
    {
        /// <summary>
        /// Coordinata X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Coordinata Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Costruttore con tutti parametri
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>

        public Loc2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Costruttore con nessun parametro
        /// </summary>

        public Loc2D()
        {
            X = 1;
            Y = 1;
        }

        /// <summary>
        /// Traduce l'oggetto in stringa
        /// </summary>
        /// <returns>
        /// Stringa che restituisce le Coordinate
        /// </returns>

        public override string ToString() => $"({X}, {Y})";
        public bool IsEqualTo(Loc2D loc) => this.X == loc.X && this.Y == loc.Y;

        internal bool IsEqualTo(object loc)
        {
            throw new NotImplementedException();
        }
    }
}
