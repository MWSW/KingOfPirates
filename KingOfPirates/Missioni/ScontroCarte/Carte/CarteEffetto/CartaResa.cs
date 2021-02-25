using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaResa : Carta
    {
        public CartaResa(string nome_, int determinazione_, Bitmap immagine_)
            : base(nome_, determinazione_, immagine_, "resa")
        {
            
        }
        public override void UsaCarta(Giocatore_carte_base g)
        {
           
        }

        public override Carta Clona()
        {
            throw new NotImplementedException(); //da vedere poi
        }
    }
}
