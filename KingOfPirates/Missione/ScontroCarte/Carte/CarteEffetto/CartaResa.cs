using KingOfPirates.Missione.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missione.ScontroCarte.Carte.CarteEffetto
{
    class CartaResa : Carta
    {
        public CartaResa(string nome_, int determinazione_, Bitmap immagine_)
            : base(nome_, determinazione_, immagine_)
        {
            
        }
        public override void UsaCarta(Giocatore g)
        {
           
        }
    }
}
