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
    internal class Mercantile
    {
        Carta[] Mazzo { get; set; }
        Mercantile(string nome, Image immagine, Stats stats, Loc2D loc, Carta[] mazzo) //: base(nome, immagine, stats, loc)
        {
            Mazzo = mazzo;
        }
    }
}
