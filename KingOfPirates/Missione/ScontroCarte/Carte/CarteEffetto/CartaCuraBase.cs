using KingOfPirates.Missione.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missione.ScontroCarte.Carte.CarteEffetto
{
    class CartaCuraBase : Carta
    {
        int cura; 

        public CartaCuraBase(string nome_, int determinazione_, Bitmap immagine_, int cura_) : base(nome_, determinazione_, immagine_)
        {
            cura = cura_;
        }
        public override void UsaCarta(Giocatore g)
        {
     
        }
    }
}
