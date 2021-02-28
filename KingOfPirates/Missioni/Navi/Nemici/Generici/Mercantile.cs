using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Carte;
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.Missioni.Navi.Nemici.Generici
{
    /// <summary>
    /// Nave più debole
    /// </summary>
    internal class Mercantile : NaveNemico
    {
        public Mercantile(Stats stats, Loc2D[] patrol, Nemico_carte nemico_carte)
            : base("Nave Mercantile", Properties.Resources.NaveMercantile, stats, patrol, nemico_carte)
        {
            
        }

        public override void Attacca(Nave nave)
        {
            throw new NotImplementedException();
        }
    }
}
