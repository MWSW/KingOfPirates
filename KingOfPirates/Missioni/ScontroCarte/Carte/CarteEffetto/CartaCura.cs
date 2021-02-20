using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaCura : Carta
    {
        int cura; 

        public CartaCura(string nome_, int determinazione_, Bitmap immagine_, int cura_) 
            : base(nome_, determinazione_, immagine_, "cura")
        {
            cura = cura_;
        }
        public override void UsaCarta(Giocatore_carte_base g)
        {
            base.UsaCarta(g);

            Random rng = new Random();

            g.AddHp(rng.Next(2, cura)); //cura il personaggio
        }

        public override Carta Clona()
        {
            return new CartaCura(nome, determinazione, immagine, cura);
        }
    }
}
