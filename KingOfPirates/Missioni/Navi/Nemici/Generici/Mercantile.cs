using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Missioni.Navi.Nemici.Generici
{
    /// <summary>
    /// Nave più debole
    /// </summary>
    internal class Mercantile : NaveNemico
    {
        Carta Mazzo { get; set; }
        public Mercantile(Stats stats, Loc2D[] patrol, Carta mazzo) : base("Nave Mercantile", Properties.Resources.nave_bianca, stats, patrol)
        {
            Mazzo = mazzo;
        }
    }
}
