using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// nave piu forte

namespace KingOfPirates.Missioni.Navi.Nemici.Generici
{
    /// <summary>
    /// Nave più forte
    /// </summary>
    internal class Fregata : NaveNemico
    {
        public Fregata(Stats stats, Loc2D[] patrol, Nemico_carte nemico_carte)
         : base("Fregata", Properties.Resources.nave_rossa, stats, patrol, nemico_carte)
        {

        }
        public override void Attacca(Nave nave)
        {
            throw new NotImplementedException();
        }
    }
}
