using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaDannoContinuo : Carta
    {
        int danno;
        int durata;
        public CartaDannoContinuo(string nome_, int determinazione_, Bitmap immagine_, int danno_, int durata_)
              : base(nome_, determinazione_, immagine_, "dannoContiuno")
        {
            danno = danno_;
            durata = durata_;
        }
        public override void UsaCarta(Giocatore_carte_base g)
        {

        }
    }
}
