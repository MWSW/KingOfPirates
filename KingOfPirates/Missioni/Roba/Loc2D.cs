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

        public Loc2D(int x_, int y_)
        {
            X = x_;
            Y = y_;
        }

        public Loc2D()
        {
            X = 0;
            Y = 0;
        }
    }
}
