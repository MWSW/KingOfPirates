using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Roba
{
    public class Loc2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Loc2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
