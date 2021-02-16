using KingOfPirates.Missioni.ScontroCarte.Carte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    class Mazzo
    {
        Carta[] carte;
        bool[] disponibile;
            
        public Mazzo(Carta[] carte_)
        {
            carte = carte_;
            disponibile = new bool[carte.Length];

            for (int i = 0; i < disponibile.Length; i++)
                disponibile[i] = true;
        }

        public Carta PrendiCarta(int indice)
        {
            if (disponibile[indice])
            {
                disponibile[indice] = false;
                return carte[indice];
            }
            else
                return null;
        }

        public void RiponiCarta(int indice)
        {
            disponibile[indice] = true;
        }

        public bool CartaDisponibile(int indice)
        {
            return disponibile[indice];
        }

        public int Length { get => carte.Length; }
    }
}
