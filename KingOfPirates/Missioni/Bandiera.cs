using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;

namespace KingOfPirates.Missioni
{
    class Bandiera
    {
        private bool missioneEnd;
        private bool giocoEnd;
        public Loc2D Coords { get; set; }

        public Bandiera(int coordX, int coordY)
        {
            Coords.X = coordX;
            Coords.Y = coordY;
            missioneEnd = false;
            giocoEnd = false;
        }

        public bool MissioneEnd { get => missioneEnd; set => missioneEnd = value; }
        public bool GiocoEnd { get => giocoEnd; set => giocoEnd = value; }

        public void IsDone()
        {
            // TODO
        }

        public void Termina(string msg)
        {
            Console.WriteLine(msg);
            Gioco.End();
        }
    }
}
