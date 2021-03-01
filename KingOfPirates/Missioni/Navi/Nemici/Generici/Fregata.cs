using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Navi.Nemici.Generici
{
    /// <summary>
    /// Nave più forte
    /// </summary>
    internal class Fregata : NaveNemico
    {
        /// <summary>
        /// Inizializza con nome e immagine della nave fregata
        /// </summary>
        /// <param name="stats"></param>
        /// <param name="patrol"></param>
        /// <param name="nemico_carte"></param>
        public Fregata(Stats stats, Loc2D[] patrol, Nemico_carte nemico_carte)
         : base("Fregata", Properties.Resources.nave_rossa, stats, patrol, nemico_carte)
        {

        }
    }
}
