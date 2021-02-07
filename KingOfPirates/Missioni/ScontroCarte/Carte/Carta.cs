using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.Missioni.ScontroCarte.Carte
{
    abstract class Carta
    {
        protected string nome;
        protected int determinazione;
        protected bool utilizzabile;
        protected Bitmap immagine;

        public Carta(string nome_, int determinazione_, Bitmap immagine_)
        {
            nome = nome_;
            determinazione = determinazione_;
            immagine = immagine_;
        }

        public abstract void UsaCarta(Giocatore utilizzatore); //FIXME

        public void AddDeterminazione(int val)
        {
           determinazione += val;
        } 
        public void DimDeterminazione(int val)
        {
           determinazione -= val;
        } 

        public bool GetUtilizzabile()
        {
            return utilizzabile;
        }

        public void SetUtilizzabile(bool b)
        {
            utilizzabile = b;
        }
    }
}
