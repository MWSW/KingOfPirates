using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.ScontroCarte.Opponenti;

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaDebuff : Carta
    {
        private int debuff;

        private int durata; //durata in turni

        public CartaDebuff(string nome_, int determinazione_, Bitmap immagine_, int debuff_, int durata_) 
            : base(nome_, determinazione_, immagine_, "debuff")
        {
            debuff = debuff_;

            durata = durata_;
        }
        public override void UsaCarta(Giocatore_carte_base g)
        {

        }

        public override Carta Clona()
        {
            return new CartaBuff(nome, determinazione, immagine, debuff, durata);
        }
    }
}
