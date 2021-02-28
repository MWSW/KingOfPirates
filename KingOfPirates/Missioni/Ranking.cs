using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    public class Ranking
    {
        public int Turni { get; set; }
        public int GameOver { get; set; }
        public int Rubini { get; set; }
        public int NaviAffondate { get; set; }

        public Ranking()
        {
            Turni = 0;
            GameOver = 0;
            Rubini = 0;
            NaviAffondate = 0;
        }

        public void IncTurni()
        {
            Turni++;
        }

        public void IncGameOver()
        {
            GameOver++;
        }

        public void IncRubini()
        {
            Rubini++;
        }

        public void IncNaviAffondate()
        {
            NaviAffondate++;
        }
    }
}
