using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using KingOfPirates.Missioni;

namespace KingOfPirates.Mappa
{
    class Cartina
    {
        private Bitmap immagine;

        Missione[] arcipelago1;
        Missione[] arcipelago2;

        public Cartina(Bitmap immagine_)
        {
            immagine = immagine_;
        }

        public void AvvioMissione()
        {

        }
    }
}
