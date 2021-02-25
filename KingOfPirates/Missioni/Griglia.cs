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

        public Griglia(Loc2D matSize, bool randomizzaMatr)
        {
            this.matSize = matSize;
            mat = new int[matSize.X, matSize.Y];

            if (randomizzaMatr) RandMatrice();
        }

        public Griglia(int[,] mat)
        {
            this.mat = mat;
        }

        private void RandMatrice()
        {
            for (int i = 0; i < matSize.X; i++)
            {
                for (int j = 0; j < matSize.Y; j++)
                {
                    mat[i, j] = new Random().Next(3);
                }
            }
        }

        //Properties/Proprieta'

        public int[,] Mat { get => mat; set => mat = value; }
    }
}
