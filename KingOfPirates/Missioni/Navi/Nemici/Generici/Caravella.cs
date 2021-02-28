using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// nave intermedia

namespace KingOfPirates.Missioni.Navi.Nemici.Generici
{
    /// <summary>
    /// Nave di forza intermedia
    /// </summary>
    internal class Caravella : NaveNemico
    {
        public Caravella(Stats stats, Loc2D[] patrol, Nemico_carte nemico_carte)
           : base("Caravella bella", Properties.Resources.nave_verde, stats, patrol, nemico_carte)
        {

        }
    }
}
