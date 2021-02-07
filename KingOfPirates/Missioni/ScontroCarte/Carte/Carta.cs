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

        public abstract void usaCarta(Giocatore g);

        //Emanuele perchè hai messo un boolean? (Ruben)
        public void addDeterminazione(bool b)
        {

        }

        //Alternativa proposta:
        /*
        public void addDeterminazione(int val)
        {
           determinazione += val;
        } 
        */

        //Emanuele perchè restituisce un boolean? (Ruben)
        public bool dimDeterminazione()
        {
            return false;
        }

        //Alternativa proposta:
        /*
        public void dimDeterminazione(int val)
        {
           determinazione -= val;
        } 
        */

        public bool getUtilizzabile()
        {
            return utilizzabile;
        }

        public void setUtilizzabile(bool b)
        {
            utilizzabile = b;
        }
    }
}
