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

        public Griglia(int matSize, bool randomizzaMatr)
        {
            mat = new int[matSize, matSize];

            if (randomizzaMatr) RandMatrice();
        }

        private void RandMatrice()
        {
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    mat[i, j] = new Random().Next(3);
                }
            }
        }

        //Properties/Proprieta'

        public int[,] Mat { get => mat; set => mat = value; }
    }
}
