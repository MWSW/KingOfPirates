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
        private int Ubriachezza { get; set; }
        public int Energia { get; set; }
        public int EnergiaMax { get; set; }
        public Inventario Inventario { get; set; }

        public NaveGiocatore(string nome_, Bitmap immagine_, Stats stats_, Loc2D loc_, int energiaMax) : base(nome_, immagine_, stats_, loc_)
        {
            StaNavigando = false;
            Ubriachezza = 0;
            EnergiaMax = energiaMax;
            Energia = EnergiaMax;
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

        //TODO: public void UsaOggetto(Oggetto o){}
    }
}
