using KingOfPirates.Missione.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missione.ScontroCarte.Carte.CarteEffetto
{
    class CartaCuraEstesa : Carta
    {
        int cura;
        int durata; 

        public CartaCuraEstesa(string nome_, int determinazione_, Bitmap immagine_, int cura_,  int durata_) 
            : base(nome_, determinazione_, immagine_)
        {
            cura = cura_;
            durata = durata_;
        }

        public override void usaCarta(Giocatore g)
        {
  
        }
    }
}
