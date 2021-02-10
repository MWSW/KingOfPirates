using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    class Griglia
    {
        private int righe, colonne;

        private int[,] mat;

        public Griglia(int righe_, int colonne_, bool randomizzaMatr)
        {
            righe = righe_;
            colonne = colonne_;
            mat = new int[righe, colonne];

            if (randomizzaMatr) RandMatrice();
        }

        private void RandMatrice()
        {
            foreach (var num in mat)
            {
                //
            }
        }

        //Properties/Proprieta'

        public int[,] Mat { get => mat; set => mat = value; }
        public int Righe { get => righe; set => righe = value; }
        public int Colonne { get => colonne; set => colonne = value; }
    }
}
