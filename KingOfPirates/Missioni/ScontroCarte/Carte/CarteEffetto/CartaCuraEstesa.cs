using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //per le Bitmap
using System.Windows.Forms;

namespace KingOfPirates.Missioni.ScontroCarte.Carte.CarteEffetto
{
    class CartaCuraEstesa : Carta
    {
        int cura;
        int durata;

        public CartaCuraEstesa(string nome_, int determinazione_, Bitmap immagine_, int cura_, int durata_) 
            : base(nome_, determinazione_, immagine_, "curaEstesa")
        {
            cura = cura_;
            durata = durata_;
        }

        public override void UsaCarta(Giocatore_carte_base g)
        {
            base.UsaCarta(g);

            //solo per il player
            Player_carte player = ((Player_carte)(g));
            player.BuffCura(cura, durata);
        }

        public override Carta Clona()
        {
            return new CartaCuraEstesa(nome, determinazione, immagine, cura, durata);
        }
    }
}
