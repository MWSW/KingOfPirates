using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.ScontroCarte.Carte;

// nave piu debole

namespace KingOfPirates.Missioni.Navi.Nemici.Generici
{
    internal class Mercantile
    {
        Carta[] Mazzo { get; }
        Mercantile(string nome, Image immagine, Stats stats, Loc2D loc, Carta[] mazzo) //: base(nome, immagine, stats, loc)
        {
            Mazzo = mazzo;
        }
    }
}
