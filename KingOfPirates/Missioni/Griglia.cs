using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingOfPirates.Missioni.Roba;

namespace KingOfPirates.Missioni
{
    /// <summary>
    /// Griglia numerica su cui verrà basata la griglia grafica
    /// </summary>
    public class Griglia
    {
        private int[,] mat;
        private Loc2D matSize;

        /// <summary>
        /// Costruttore che inizializza una matrice in base a quella data
        /// </summary>
        /// <param name="mat">Matrice numerica</param>
        public Griglia(int[,] mat)
        {
            this.mat = mat;
        }

        //Properties/Proprieta'

        public int[,] Mat { get => mat; set => mat = value; }
    }
}
