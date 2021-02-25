using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using KingOfPirates.Missioni.ScontroCarte.Carte;

namespace KingOfPirates.Missioni.ScontroCarte.Opponenti
{
    class Nemico_carte : Giocatore_carte_base
    {
        private Carta[] mazzo;
        private Carta cartaUsata;

        private int debuff;
        private int nTurniDebuff;
        private bool debuffApplicato;

        private int danno;
        private int nTurniDanno;
        private bool dannoApplicato;

        public Nemico_carte(int hp_, Bitmap img_, Carta[] mazzo_)
            : base(hp_, img_)
        {
            debuffApplicato = false;
            nTurniDebuff = 0;
            debuff = 0;


            mazzo = mazzo_;
        }

        public void ScegliCarta()
        {
            Random rng = new Random();
            cartaUsata = mazzo[rng.Next(0, mazzo.Length -1)];  //FIX-ME (non va bene il mazzo)
        }

        public void Debuff(int debuff_, int turni_)
        {
            //valori negativi
            debuff = debuff_;
            nTurniDebuff = turni_;

            debuffApplicato = true;
        }

        public void ApplicaDebuff()
        {
            //riduco turni per il buff
            if ((nTurniDebuff - 1) > 0 && debuffApplicato)
            {
                nTurniDebuff--;
            }
            else
            {
                debuffApplicato = false;
                debuff = 0;
            }
        }

        public void DannoPerpetuo(int danno_, int turni_)
        {
            danno = danno_;
            nTurniDanno = turni_;

            dannoApplicato = true;
        }

        public void ApplicaDannoPerpetuo()
        {
            //riduco turni per il buff
            if ((nTurniDanno - 1) > 0 && dannoApplicato)
            {
                LessHp(danno);
                nTurniDanno--;
            }
            else
            {
                dannoApplicato = false;
                danno = 0;
            }
        }

        public Carta CartaUsata { get => cartaUsata; }
        public bool DebuffApplicato { get => debuffApplicato; }
        public bool DannoApplicato { get => dannoApplicato; }
        public int DebuffVal { get => debuff; }
    }
}
