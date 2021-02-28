using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaMorto : Carta
    {
        public CartaMorto(string nome_, int determinazione_, Bitmap immagine_)
            : base(nome_, determinazione_, immagine_, "morto")
        {

        }
        public override void UsaCarta(Giocatore_carte_base g)
        {
            base.UsaCarta(g);
        }

        public override Carta Clona()
        {
            return new CartaMorto(nome, determinazione, immagine);
        }
    }
}
