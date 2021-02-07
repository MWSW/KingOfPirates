using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missione.ScontroCarte.Opponenti;

namespace KingOfPirates.Missione.ScontroCarte.Carte
{
    class CartaBase : Carta
    {
        private int atk;
        private int def;
        private double buffApplicato; //Emanuele perche double e non int? (Ruben)
        private char elemento;
        public CartaBase(string nome_, int determinazione_, Bitmap immagine_, int atk_, int def_, char elemento_)
            :base(nome_, determinazione_, immagine_)
        {
            atk = atk_;
            def = def_;
            elemento = elemento_;
        }

        public override void usaCarta(Giocatore g)
        {
            
        }

        public void applicaBuff(double buff) 
        {

        }
    }
}
