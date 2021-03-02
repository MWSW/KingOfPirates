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
    /// Nave di forza intermedia
    /// </summary>
    internal class Caravella : NaveNemico
    {
        /// <summary>
        /// Inizializza con nome e immagine della nave caravella
        /// </summary>
        /// <param name="stats"></param>
        /// <param name="patrol"></param>
        /// <param name="nemico_carte"></param>
        public Caravella(Stats stats, Loc2D[] patrol, Nemico_carte nemico_carte)
           : base("Caravella bella", Properties.Resources.nave_verde, stats, patrol, nemico_carte)
        {

        }
    }
}
