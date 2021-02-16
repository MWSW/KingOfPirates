using KingOfPirates.Missioni.ScontroCarte.Carte;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    class Player_carte : Giocatore_carte_base
    {
        private Carta[] carteInMano; 

        public Player_carte(int hp_, Mazzo mazzo_)
            : base(hp_, Properties.Resources.pun_pun, mazzo_) //pup pun è un'immagine di prova
        {
            //assegna delle carte alla mano
            carteInMano = new Carta[4];

            Random rng = new Random();
            for(int i = 0; i < carteInMano.Length; i++)
            {

                int num;
                do
                {
                    num = rng.Next(0, mazzo.Lenght);
                }
                while (!mazzo.CartaDisponibile(num)); //ripesca se la carta non è disponibile

                carteInMano[i] = mazzo.PrendiCarta(num); //assegna carte random dalla mano               
            }
        }

        public void UsaCarta(int n)
        {

        }

        public void UsaOggetto(int n)
        {

        }

        public Carta[] CarteInMano { get => carteInMano; }
    }
}
