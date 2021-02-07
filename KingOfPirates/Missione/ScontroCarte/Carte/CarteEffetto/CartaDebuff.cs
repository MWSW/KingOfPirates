using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missione.ScontroCarte.Opponenti;

namespace KingOfPirates.Missione.ScontroCarte.Carte.CarteEffetto
{
    class CartaDebuff : Carta
    {
        private double debuffAtk;
        private double debuffDef;

        private int durata; //durata in turni

        public CartaDebuff(string nome_, int determinazione_, Bitmap immagine_, int debuffAtk_, int debuffDef_, int durata_) : base(nome_, determinazione_, immagine_)
        {
            debuffAtk = debuffAtk_;
            debuffDef = debuffDef_;

            durata = durata_;
        }
        public override void UsaCarta(Giocatore g)
        {

        }
    }
}
