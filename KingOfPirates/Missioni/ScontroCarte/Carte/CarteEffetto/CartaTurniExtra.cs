using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaTurniExtra : Carta
    {
        private int nTurni; //turni extra ottenuti

        public CartaTurniExtra(string nome_, int determinazione_, Bitmap immagine_, int nTurni_)
            : base(nome_, determinazione_, immagine_, "turni extra")
        {
            nTurni = nTurni_;
        }
        public override void UsaCarta(Giocatore_carte_base utilizzatore)
        {
            
        }

        public override Carta Clona()
        {
            return new CartaTurniExtra(nome, determinazione, immagine, nTurni);
        }
    }
}
