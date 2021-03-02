using KingOfPirates.Missioni.ScontroCarte.Carte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    public class Mazzo
    {
        Carta[] carte;
        bool[] disponibile;

        public int CarteMorte { get; set; }
            
        public Mazzo(Carta[] carte_)
        {
            carte = carte_;
            disponibile = new bool[carte.Length];

            CarteMorte = 0; //contatore parte da zero

            for (int i = 0; i < disponibile.Length; i++)
            {
                disponibile[i] = true;
                carte[i].Indice = i;
            }
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

        public void MorteCarta(int indice)
        {
            //sostituisci posizione con carta morta
            carte[indice] = ListaCarte.GetMorto();

            //setto un idice altrimenti esplode tutto
            carte[indice].Indice = indice;

            CarteMorte++; //incrementa il contatore
        }

        public bool CartaDisponibile(int indice)
        {
            return disponibile[indice];
        }

        public int Length { get => carte.Length; }
    }
}
