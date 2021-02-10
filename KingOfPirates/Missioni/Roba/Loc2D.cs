using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.Roba
{
    class Loc2D
    {
        private int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Loc2D(int x_, int y_)
        {
            x = x_;
            y = y_;
        }

        public Loc2D()
        {
            x = 0;
            y = 0;
        }
    }
}
