using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //Per le Bitmap
using KingOfPirates.Missioni.Roba;
using KingOfPirates.Missioni.Navi.Opponenti;

namespace KingOfPirates.Missioni.Navi
{
    public class NaveGiocatore : Nave
    {
        private bool StaNavigando { get; set; } //Verifica che sia su terreno o meno
        public int Ubriachezza { get; set; }
        public int UbriachezzaMax { get; set; }
        public int Energia { get; set; }
        public int EnergiaMax { get; set; }

        public int Determinazione { get; set; }
        public int DeterminazioneMax { get; set; }
        public int PuntiVita { get; set; }
        public int PuntiVitaMax { get; set; }
        public Inventario Inventario { get; set; }

        public NaveGiocatore(string nome_, Bitmap immagine_, Stats stats_, Loc2D loc_, int energiaMax, int ubriachezzaMax, int determinazioneMax, int puntiVitaMax) : base(nome_, immagine_, stats_, loc_)
        {
            StaNavigando = false;
            UbriachezzaMax = ubriachezzaMax;
            Ubriachezza = 0;
            EnergiaMax = energiaMax;
            Energia = EnergiaMax;
            DeterminazioneMax = determinazioneMax;
            Determinazione = (int)(DeterminazioneMax * 0.75f); //parte da 3/4 del totale
            PuntiVitaMax = puntiVitaMax;
            PuntiVita = 6; //FIXME
            Inventario = new Inventario(5,5,5,5); //TEMP
        }

        public override void Movimento(Loc2D spostamento)
        {
            base.Movimento(spostamento);
        }

        public void Abborda(NaveNemico nave)
        {

        }
        public void Scavare() 
        {

        }

        public void RemEnergia(int enTolta)
        {
            Energia -= enTolta;
        }

        public void IncUbriachezza(int punti)
        {
            Ubriachezza += punti;

            if (Ubriachezza > UbriachezzaMax)
                Ubriachezza = UbriachezzaMax;
        }

        public void DecUbriachezza(int punti)
        {
            Ubriachezza -= punti;

            if (Ubriachezza < 0)
                Ubriachezza = 0;
        }

        public void IncDeterminazione(int punti)
        {
            Determinazione += punti;

            if (Determinazione > DeterminazioneMax)
                Determinazione = DeterminazioneMax;
        }

        public void DecDeterminazione(int punti)
        {
            Determinazione -= punti;

            if (Determinazione < 0)
                Determinazione = 0;
        }

        public void IncPuntiVita(int punti)
        {
            PuntiVita += punti;

            if (PuntiVita > PuntiVitaMax)
                PuntiVita = PuntiVitaMax;
        }

        public void DecPuntiVita(int punti)
        {
            PuntiVita -= punti;

            if (PuntiVita < 0)
                PuntiVita = 0;
        }

        //TODO: public void UsaOggetto(Oggetto o){}
    }
}
