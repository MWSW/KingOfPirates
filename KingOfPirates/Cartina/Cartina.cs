using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using KingOfPirates.Missioni;

namespace KingOfPirates.Cartina
{
    class Cartina
    {
        private Bitmap immagine;

        Missione[] arcipelago1;
        Missione[] arcipelago2;

        public Cartina(Bitmap immagine_, int missioniIsole1, int missioniIsole2)
        {
            immagine = immagine_;
            this.arcipelago1 = new Missione[missioniIsole1];
            this.arcipelago2 = new Missione[missioniIsole2];
        }

        public void AvvioMissione()
        {
            //
        }
    }
}
