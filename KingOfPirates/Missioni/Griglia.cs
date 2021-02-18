using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    class Griglia
    {
        private int[,] mat;
        private int matSize;

        public Griglia(int matSize, bool randomizzaMatr)
        {
            mat = new int[matSize, matSize];
            this.matSize = matSize;

            if (randomizzaMatr) RandMatrice();
        }

        private void RandMatrice()
        {
            for (int i = 0; i < matSize; i++)
            {
                for (int j = 0; j < matSize; j++)
                {
                    mat[i, j] = new Random().Next(3);
                }
            }
        }

        //Properties/Proprieta'

        public int[,] Mat { get => mat; }
    }
}
