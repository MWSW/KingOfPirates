using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni
{
    class Griglia
    {
        private int righe;
        private int colonne;

        int[] mat;

        public Griglia(int righe_, int colonne_)
        {
            righe = righe_;
            colonne = colonne_;

            //usare y*colonne + x -> per trovare una posizione della matrice [x][y]
            //realizzata così perchè dava errore nella generazione della matrice classica
            mat = new int[righe*colonne];
        }
    }
}
