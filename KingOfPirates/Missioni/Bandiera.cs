using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    class Bandiera
    {
        private static bool missioneEnd;
        private static bool giocoEnd;

        public Bandiera()
        {
            missioneEnd = false;
            giocoEnd = false;
        }

        public void IsDone()
        {
            if (missioneEnd)
            {
                //TODO
            }

            if (giocoEnd)
            {
                Termina("App terminata in Bandiera.IsDone");
            }
        }

        public void Termina(string msg)
        {
            Console.WriteLine(msg);
            System.Windows.Forms.Application.Exit();
        }

        public static bool MissioneEnd { get => missioneEnd; set => missioneEnd = value; }
        public static bool GiocoEnd { get => giocoEnd; set => giocoEnd = value; }
    }
}
