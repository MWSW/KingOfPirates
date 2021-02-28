using KingOfPirates.Missioni.ScontroCarte.Carte;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    public class Player_carte : Giocatore_carte_base
    {
        private Carta[] carteInMano;
        private Mazzo mazzo;

        private int buffCura;
        private int turniBuffCura;

        private bool curaEstesa;

        private int buffStats;
        private int turniBuffStats;

        private bool buffApplicato;

        public Player_carte(int hp_, Mazzo mazzo_)
            : base(hp_, Properties.Resources.pun_pun, "Ishmael") //pup pun è un'immagine di prova
        {
            mazzo = mazzo_;

            curaEstesa = false;
            buffCura = 0;
            turniBuffCura = 0;

            //assegna delle carte alla mano
            carteInMano = new Carta[4];

            Random rng = new Random();
            for(int i = 0; i < carteInMano.Length; i++)
            {

                int num;
                do
                {
                    num = rng.Next(0, mazzo.Length);
                }
                while (!mazzo.CartaDisponibile(num)); //ripesca se la carta non è disponibile

                carteInMano[i] = mazzo.PrendiCarta(num); //assegna carte random dalla mano               
            }
        }

        public void PescaCarta(int posizione)
        {
            Random rng = new Random();
            int num;
            do
            {
               num = rng.Next(0, mazzo.Length);
            }
            while (!mazzo.CartaDisponibile(num)); //ripesca se la carta non è disponibile

            mazzo.RiponiCarta(carteInMano[posizione].Indice); 
            //riponi la carta dopo l'estrazione così da non riceverla subito indietro

            carteInMano[posizione] = mazzo.PrendiCarta(num); //assegna carte random dalla mano               
        }

        public void BuffCura(int buffCura_, int turniBuffCura_)
        {
            buffCura = buffCura_;
            turniBuffCura = turniBuffCura_;

            curaEstesa = true;
        }

        public void BuffStats(int buffStats_, int turniBuffStats_)
        {
            buffStats = buffStats_;
            turniBuffStats = turniBuffStats_;

            buffApplicato = true;
        }

        public void ApplicaBuffCura()
        {
            if((turniBuffCura -1)> 0 && curaEstesa)
            {
                AddHp(buffCura);
                turniBuffCura--;
            }
            else
            {
                curaEstesa = false;
            }
        }

        public void ApplicaBuffStats()
        {
            //riduco turni per il buff
            if ((turniBuffStats - 1) > 0 && buffApplicato)
            {
                turniBuffStats--;
            }
            else
            {
                buffApplicato = false;
                buffStats = 0;
            }
        }

        public void UsaOggetto(int n)
        {

        }

        public Carta[] CarteInMano { get => carteInMano; }
        public Mazzo Mazzo { get => mazzo; }
        public bool CuraEstesa { get => curaEstesa; }
        public bool BuffApplicato { get => buffApplicato; }
        public int ValBuff { get => buffStats; }
    }
}
