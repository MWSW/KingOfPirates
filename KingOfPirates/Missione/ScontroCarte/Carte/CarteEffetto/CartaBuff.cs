using KingOfPirates.Missione.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap

namespace KingOfPirates.Missione.ScontroCarte.Carte.CarteEffetto
{
    class CartaBuff : Carta
    {
        private double buffAtk;
        private double buffDef;

        private int durata; //durata in turni

        public CartaBuff(string nome_, int determinazione_, Bitmap immagine_, int buffAtk_, int buffDef_, int durata_) : base(nome_, determinazione_, immagine_)
        {
            buffAtk = buffAtk_;
            buffDef = buffDef_;

            durata = durata_;
        }
        public override void usaCarta(Giocatore g)
        {
         
        }
    }
}
