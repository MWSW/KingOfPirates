using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missione.Roba
{
    class Loc2D
    {
        private int x;
        private int y;
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

        public int GetX() { return x; }
        public int GetY() { return y; }
        public void SetX(int x_) { x = x_; }
        public void SetY(int y_) { y = y_; }
    }
}
