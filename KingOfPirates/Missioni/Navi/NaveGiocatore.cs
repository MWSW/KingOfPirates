using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Per le Image
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.Navi.Opponenti;

namespace KingOfPirates.Missioni.Navi
{
    public class NaveGiocatore : Nave
    {
        /// <summary>
        /// Verifica che sia su terreno o meno
        /// </summary>
        private bool StaNavigando { get; set; }
        public int Ubriachezza { get; set; }
        public int UbriachezzaMax { get; set; }
        public int Determinazione { get; set; }
        public int DeterminazioneMax { get; set; }
        public Inventario Inventario { get; set; }

        /// <summary>
        /// Unico costruttore con tutti parametri
        /// </summary>
        /// <param name="nome_"></param>
        /// <param name="immagine_"></param>
        /// <param name="stats_"></param>
        /// <param name="loc_"></param>
        /// <param name="ubriachezzaMax"></param>
        /// <param name="determinazioneMax"></param>

        public NaveGiocatore(string nome_, Image immagine_, Stats stats_, Loc2D loc_, int ubriachezzaMax, int determinazioneMax) : base(nome_, immagine_, stats_, loc_)
        {
            StaNavigando = false;
            UbriachezzaMax = ubriachezzaMax;
            Ubriachezza = 0;
            DeterminazioneMax = determinazioneMax;
            Determinazione = (int)(DeterminazioneMax * 0.75f); //parte da 3/4 del totale
            Inventario = new Inventario(5,5,5,5); //FIXME
        }

        public void Abborda(NaveNemico nave)
        {
            //
        }
        public void Scavare() 
        {
            //
        }

        public override void RemEnergia(int enTolta)
        {
            Stats.Pa -= enTolta;
        }

        public override void IncUbriachezza(int punti)
        {
            Ubriachezza += punti;

            if (Ubriachezza > UbriachezzaMax)
                Ubriachezza = UbriachezzaMax;
        }

        public override void DecUbriachezza(int punti)
        {
            Ubriachezza -= punti;

            if (Ubriachezza < 0)
                Ubriachezza = 0;
        }

        public override void IncDeterminazione(int punti)
        {
            Determinazione += punti;

            if (Determinazione > DeterminazioneMax)
                Determinazione = DeterminazioneMax;
        }

        public override void DecDeterminazione(int punti)
        {
            Determinazione -= punti;

            if (Determinazione < 0)
                Determinazione = 0;
        }

        public override void IncPuntiVita(int punti)
        {
            Stats.Hp += punti;

            if (Stats.Hp > Stats.HpMax)
                Stats.Hp = Stats.HpMax;
        }

        public override void DecPuntiVita(int punti)
        {
            Stats.Hp -= punti;

            if (Stats.Hp < 0)
                Stats.Hp = 0;
        }

        //TODO: public void UsaOggetto(Oggetto ob){}
    }
}
