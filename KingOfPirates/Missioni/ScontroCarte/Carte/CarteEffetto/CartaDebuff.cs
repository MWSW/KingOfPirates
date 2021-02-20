using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.ScontroCarte.Opponenti;
using System.Windows.Forms;

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
            Nemico_carte nemico = (Nemico_carte)g; //funziona solo sul nemico

            if (nemico != null)
            {
                nemico.Debuff(debuff, durata); //applichi il buff al giocatore, poi questo si occuperara di passare il buff alle carte
            }
            else
            {
                MessageBox.Show("Error - non puoi usare una carta Buff con un nemico");
            }
        }

        public override Carta Clona()
        {
            return new CartaDebuff(nome, determinazione, immagine, debuff, durata);
        }
    }
}
