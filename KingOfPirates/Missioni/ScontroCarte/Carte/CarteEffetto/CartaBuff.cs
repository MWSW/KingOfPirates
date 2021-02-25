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
    class CartaBuff : Carta
    {
        private int buff;

        private int durata; //durata in turni

        public CartaBuff(string nome_, int determinazione_, Bitmap immagine_, int buff_, int durata_) 
            : base(nome_, determinazione_, immagine_, "buff")
        {
            buff = buff_;

            durata = durata_;
        }
        public override void UsaCarta(Giocatore_carte_base utilizzatore)
        {
            base.UsaCarta(utilizzatore);

            Player_carte player = (Player_carte)utilizzatore; //funziona solo sul player

            if(player != null)
            {
                player.BuffStats(buff, durata); //applichi il buff al giocatore, poi questo si occuperara di passare il buff alle carte
            }
            else
            {
                MessageBox.Show("Error - non puoi usare una carta Buff con un nemico");
            }
        }

        public override Carta Clona()
        {
            return new CartaBuff(nome, determinazione, immagine, buff, durata);
        }
    }
}
