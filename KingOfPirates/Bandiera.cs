using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates
{
    class Bandiera
    {
        private static bool missionEnd;
        private static bool gameEnd;

        public Bandiera()
        {
            missionEnd = false;
            gameEnd = false;
        }

        public void IsDone()
        {
            // TODO
        }

        public void Termina(string msg)
        {
            Console.WriteLine(msg);
            System.Windows.Forms.Application.Exit();
        }
    }
}
